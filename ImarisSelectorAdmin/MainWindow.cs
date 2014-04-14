using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ImarisSelectorLib;
using System.Collections.Generic;

namespace ImarisSelectorAdmin
{
    /// <summary>
    /// ImarisSelectorAdmin main window.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Application settings
        /// </summary>
        private Settings m_Settings;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainWindow()
        {
            // Initialize the UI
            InitializeComponent();

            // Make window unresizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Get the application settings from the settings file.
            this.m_Settings = SettingsManager.read();
            if (this.m_Settings.IsValid)
            {
                buttonImarisPath.Text = this.m_Settings.ImarisPath;

                // Fill in the list of products
                checkedListBoxProducts.Items.Clear();
                foreach (String productName in this.m_Settings.ProductsWithEnabledState.Keys)
                {
                    bool state;
                    if (this.m_Settings.ProductsWithEnabledState.ContainsKey(productName))
                    {
                        if (!this.m_Settings.ProductsWithEnabledState.TryGetValue(productName, out state))
                        {
                            state = true;
                        }
                    }
                    else
                    {
                        state = true;
                    }

                    // Add the product with the state read from the application settings
                    checkedListBoxProducts.Items.Add(productName, state);
                }

                // Now set all other settings
                // TODO: Add all necessary checks
                
                // Texture cache
                if (this.m_Settings.TextureCache == -1)
                {
                    numericTextureCache.Text = "";
                }
                else
                {
                    numericTextureCache.Value = this.m_Settings.TextureCache;
                }

                // Data cache
                if (this.m_Settings.DataCache == -1)
                {
                    numericDataCache.Text = "";
                }
                else
                {
                    numericDataCache.Value = this.m_Settings.DataCache;
                }

                // Data cache file paths
                if (!this.m_Settings.DataBlockCachingFilePath.Equals(""))
                {
                    String[] dataBlockCachingFilePathArray = this.m_Settings.DataBlockCachingFilePath.Split(';');
                    listCLFileCachePaths.Items.Clear();
                    foreach (String d in dataBlockCachingFilePathArray)
                    {
                        if (!d.Equals(""))
                        {
                            listCLFileCachePaths.Items.Add(d);
                        }
                    }
                }

                // XT folder paths
                if (!this.m_Settings.XTFolderPath.Equals(""))
                {
                    String[] xtFolderPathArray = this.m_Settings.XTFolderPath.Split(';');
                    listCTXTPaths.Items.Clear();
                    foreach (String x in xtFolderPathArray)
                    {
                        if (!x.Equals(""))
                        {
                            listCTXTPaths.Items.Add(x);
                        }
                    }
                }

                // Python path
                if (!this.m_Settings.PythonPath.Equals(""))
                {
                    buttonCTAddPythonPath.Text = this.m_Settings.PythonPath;
                }

                // Fiji path
                if (!this.m_Settings.FijiPath.Equals(""))
                {
                    buttonCTAddFijiPath.Text = this.m_Settings.FijiPath;
                }

                // Enable save button
                this.buttonSave.Enabled = true;
            }
        }

        /// <summary>
        /// Ask the admin to pick the Imaris executable to be managed by ImarisSelector.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImarisPath_Click(object sender, EventArgs e)
        {
            // Open a file dialog to pick the Imaris executable
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            dialog.Title = "Please select the Imaris executable to manage";
            DialogResult result = dialog.ShowDialog();
	        if (result == DialogResult.OK)
	        {
                // Set the Imaris path
                this.m_Settings.ImarisPath = dialog.FileName;
                
                // Display it also on the button
                buttonImarisPath.Text = dialog.FileName;

                // Extract version information from the Imaris path
                if (processImarisExecutablePath() == true)
                {
                    // (Re)populate the product list
                    FillProductList();

                    // Enable the save button
                    this.buttonSave.Enabled = true;
                }
	        }
        }

        /// <summary>
        /// Processes the Imaris executable path to extract version information.
        /// </summary>
        private bool processImarisExecutablePath()
        {
            // Get the Imaris version from the path
            // We need to extract the optional 'x64 string' and major plus minor
            // version to look up the correct licenses in the registry. The patch
            // version is ignored.
            Match match = Regex.Match(this.m_Settings.ImarisPath, 
                @"(Imaris)\s*(x64)*\s*(\d{1,2}).(\d{1,2})(.\d{1,2})*\\Imaris\.exe",
                RegexOptions.IgnoreCase);
            if (match.Success)
            {
                if (!match.Groups[2].Value.Equals("x64"))
                {
                    // 32-bit version of Imaris
                    this.m_Settings.ImarisVersion = match.Groups[1].Value + " " +
                        match.Groups[3].Value + "." +
                        match.Groups[4].Value;
                }
                else
                {
                    // 64-bit version of Imaris
                    this.m_Settings.ImarisVersion = match.Groups[1].Value + " " +
                        match.Groups[2].Value + " " +
                        match.Groups[3].Value + "." +
                        match.Groups[4].Value;
                }
            }
            else
            {
                // Inform the user
                MessageBox.Show("Invalid Imaris executable selected!\n" +
                    "Please try again.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Return success
            return true;

        }

        /// <summary>
        /// Display application help.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Display short usage help
            MessageBox.Show("The administrator backend of ImarisSelector lets you choose\n" +
                "the Imaris executable to manage and which products to make visible\n" +
                "to the user in ImarisSelector.\n\n" +
                "Moreover, it optionally allows you to push settings that are otherwise\n" +
                "responsibility of the user to set.",
                "ImarisSelector :: Admin -- Help",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Return the application version.
        /// </summary>
        /// <returns></returns>
        private String GetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.ProductVersion;
        }

        /// <summary>
        /// Display application About dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Display version and copyright information
            MessageBox.Show("ImarisSelector :: Admin v" + GetVersion() + "\n\n" +
                "Aaron Ponti\n" +
                "Single-Cell Facility\n" +
                "Department of Biosystems Science and Engineering\n" +
                "ETHZ (Basel)\n" +
                "Copyright (c) 2012 - 2014.",
                "ImarisSelector :: Admin -- About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Update product description in the UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected product name
            String productName = (String)checkedListBoxProducts.SelectedItem;
            if (productName == null)
            {
                return;
            }

            String descr;
            Dictionary<String, String> productCatalog = 
                new ModuleManager(this.m_Settings).GetProductCatalog();
            if (!productCatalog.TryGetValue(productName, out descr))
            {
                descr = "Unknown module.";
            }
            labelProductDescription.Text = descr;
        }

        /// <summary>
        /// Save settings to disk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Make sure everything is set
            if (this.m_Settings.ImarisPath.Equals("") || this.m_Settings.ImarisVersion.Equals(""))
            {
                // Inform the user
                MessageBox.Show("Please choose a valid Imaris executable first!",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check whether the values for texture and data cache are set
            if (numericTextureCache.Text == "")
            {
                this.m_Settings.TextureCache = -1;
            }

            if (numericDataCache.Text == "")
            {
                this.m_Settings.DataCache = -1;
            }

            // Collect all products and states
            Dictionary<String, bool> productsWithStates = new Dictionary<String, bool>();

            // Store the items with their checked state
            for (int i = 0; i < checkedListBoxProducts.Items.Count; i++)
            {
                bool state = false;
                if (checkedListBoxProducts.GetItemChecked(i))
                {
                    state = true;
                }
                productsWithStates.Add(checkedListBoxProducts.Items[i].ToString(), state);
            }

            // Store ImarisPath and ImarisVersion to the settings file
            this.m_Settings.ProductsWithEnabledState = productsWithStates;
            if (SettingsManager.write(this.m_Settings) == false)
            {
                // The user could not write to the settings folder!
                MessageBox.Show(
                    "Sorry, you do not have sufficient rights to save the settings!\n" +
                    "Are you an administrator?",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fill in the checkedListbox based on the Settings.
        /// </summary>
        private void FillProductList()
        {
            // Add all products and activate them
            List<String> installedProducts =
                new ModuleManager(this.m_Settings).GetInstalledProductList();

            // We do not display Imaris
            installedProducts.Remove("Imaris");

            // Clear existing lists
            checkedListBoxProducts.Items.Clear();
            this.m_Settings.ProductsWithEnabledState.Clear();

            // Add the new products and states
            foreach (String productName in installedProducts)
            {
                this.m_Settings.ProductsWithEnabledState.Add(productName, true);
                checkedListBoxProducts.Items.Add(productName, true);
            }
        }

        /// <summary>
        /// Add an XT path to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCTXTPathsAdd_Click(object sender, EventArgs e)
        {
            // Open a file dialog to pick the folder
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please pick a folder containing MATLAB or python XTensions";
            dialog.ShowNewFolderButton = false;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get the path
                String folderName = dialog.SelectedPath;

                // If the path is already in the list, we inform the user and return
                if (listCTXTPaths.Items.Contains(folderName))
                {
                    // Inform the user
                    MessageBox.Show(
                        "Sorry, you cannot add the same path more than once!",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Add it to the list of paths
                listCTXTPaths.Items.Add(folderName);

                // Store them in the Settings as well
                System.Text.StringBuilder outStr = new System.Text.StringBuilder();
                foreach (var s in listCTXTPaths.Items)
                {
                    outStr.Append((String)s + ";");
                }
                this.m_Settings.XTFolderPath = outStr.ToString();
            }
        }

        /// <summary>
        /// Remove selected paths from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCTXTPathsRemove_Click(object sender, EventArgs e)
        {
            // Remove the selected indices
            for (int i = listCTXTPaths.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listCTXTPaths.Items.RemoveAt(listCTXTPaths.SelectedIndices[i]);
            }

            // Store them in the Settings as well
            System.Text.StringBuilder outStr = new System.Text.StringBuilder();
            foreach (var s in listCTXTPaths.Items)
            {
                outStr.Append((String)s + ";");
            }
            this.m_Settings.XTFolderPath = outStr.ToString();

        }

        /// <summary>
        /// Add a file cache path to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCLFileCachePathsAdd_Click(object sender, EventArgs e)
        {
            // Open a file dialog to pick the folder
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please pick a file cache folder";
            dialog.ShowNewFolderButton = false;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get the path
                String folderName = dialog.SelectedPath;

                // If the path is already in the list, we inform the user and return
                if (listCLFileCachePaths.Items.Contains(folderName))
                {
                    // Inform the user
                    MessageBox.Show(
                        "Sorry, you cannot add the same path more than once!",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Add it to the list of paths
                listCLFileCachePaths.Items.Add(folderName);

                // Store them in the Settings as well
                System.Text.StringBuilder outStr = new System.Text.StringBuilder();
                foreach (var s in listCLFileCachePaths.Items)
                {
                    outStr.Append((String)s + ";");
                }
                this.m_Settings.DataBlockCachingFilePath = outStr.ToString();

            }
        }

        /// <summary>
        /// Remove selected paths from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCLFileCachePathsRemove_Click(object sender, EventArgs e)
        {
            // Remove the selected indices
            for (int i = listCLFileCachePaths.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listCLFileCachePaths.Items.RemoveAt(listCLFileCachePaths.SelectedIndices[i]);
            }

            // Store them in the Settings as well
            System.Text.StringBuilder outStr = new System.Text.StringBuilder();
            foreach (var s in listCLFileCachePaths.Items)
            {
                outStr.Append((String)s + ";");
            }
            this.m_Settings.DataBlockCachingFilePath = outStr.ToString();
        }

        /// <summary>
        /// Select the python executable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCTAddPythonPath_Click(object sender, EventArgs e)
        {
            // Open a file dialog to pick the Python executable
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            dialog.Title = "Please select the Python executable";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set the Python path
                this.m_Settings.PythonPath = dialog.FileName;

                // Display it also on the button
                buttonCTAddPythonPath.Text = dialog.FileName;

            }
        }


        /// <summary>
        /// Reset the Python executable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCTRemPythonPath_Click(object sender, EventArgs e)
        {
            // Reset the Python path
            this.m_Settings.PythonPath = "";

            // Reset also the button
            buttonCTAddPythonPath.Text = "...";
        }

        /// <summary>
        /// Select the Fiji or ImageJ executable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCTAddFijiPath_Click(object sender, EventArgs e)
        {
            // Open a file dialog to pick the Fiji executable
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            dialog.Title = "Please select the Fiji or ImageJ executable";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set the Python path
                this.m_Settings.FijiPath = dialog.FileName;

                // Display it also on the button
                buttonCTAddFijiPath.Text = dialog.FileName;

            }
        }

        /// <summary>
        /// Reset the Fiji or ImageJ executable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCTRemFijiPath_Click(object sender, EventArgs e)
        {
            // Reset the Fiji path
            this.m_Settings.FijiPath = "";

            // Reset also the button
            buttonCTAddFijiPath.Text = "...";
        }

        /// <summary>
        /// Store the texture value into the Settings on change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericTextureCache_ValueChanged(object sender, EventArgs e)
        {
            this.m_Settings.TextureCache = (int) numericTextureCache.Value;
        }

        /// <summary>
        /// Store the data cache value into the Settings on change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericDataCache_ValueChanged(object sender, EventArgs e)
        {
            this.m_Settings.DataCache = (int)numericDataCache.Value;
        }

    }
}
