namespace ImarisSelectorAdmin
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonImarisPath = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelExpl = new System.Windows.Forms.Label();
            this.labelProductsText = new System.Windows.Forms.Label();
            this.checkedListBoxProducts = new System.Windows.Forms.CheckedListBox();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabModules = new System.Windows.Forms.TabPage();
            this.tabCache = new System.Windows.Forms.TabPage();
            this.groupBoxCacheFilePaths = new System.Windows.Forms.GroupBox();
            this.labelDataCachePathInfo = new System.Windows.Forms.Label();
            this.buttonCLFileCachePathsAdd = new System.Windows.Forms.Button();
            this.buttonCLFileCachePathsRemove = new System.Windows.Forms.Button();
            this.listCLFileCachePaths = new System.Windows.Forms.ListBox();
            this.groupBoxDataCache = new System.Windows.Forms.GroupBox();
            this.numericDataCache = new System.Windows.Forms.NumericUpDown();
            this.labelCLDataCacheSize = new System.Windows.Forms.Label();
            this.labelDataCacheSizeInfo = new System.Windows.Forms.Label();
            this.groupBoxGraphicsCard = new System.Windows.Forms.GroupBox();
            this.numericTextureCache = new System.Windows.Forms.NumericUpDown();
            this.labelTextureCacheLabel = new System.Windows.Forms.Label();
            this.labelGraphicsCardInfo = new System.Windows.Forms.Label();
            this.labelDataCachesText = new System.Windows.Forms.Label();
            this.labelCalculation = new System.Windows.Forms.Label();
            this.labelGraphicsCard = new System.Windows.Forms.Label();
            this.tabCustomTools = new System.Windows.Forms.TabPage();
            this.groupBoxFijiPath = new System.Windows.Forms.GroupBox();
            this.labelFijiPathInfo = new System.Windows.Forms.Label();
            this.buttonCTRemFijiPath = new System.Windows.Forms.Button();
            this.buttonCTAddFijiPath = new System.Windows.Forms.Button();
            this.groupBoxPythonPath = new System.Windows.Forms.GroupBox();
            this.labelPythonPathInfo = new System.Windows.Forms.Label();
            this.buttonCTRemPythonPath = new System.Windows.Forms.Button();
            this.buttonCTAddPythonPath = new System.Windows.Forms.Button();
            this.groupBoxXTFolders = new System.Windows.Forms.GroupBox();
            this.labelXTFoldersInfo = new System.Windows.Forms.Label();
            this.listCTXTPaths = new System.Windows.Forms.ListBox();
            this.buttonCTXTPathsAdd = new System.Windows.Forms.Button();
            this.buttonCTXTPathsRemove = new System.Windows.Forms.Button();
            this.labelCustomTools = new System.Windows.Forms.Label();
            this.labelCustomToolsText = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabModules.SuspendLayout();
            this.tabCache.SuspendLayout();
            this.groupBoxCacheFilePaths.SuspendLayout();
            this.groupBoxDataCache.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDataCache)).BeginInit();
            this.groupBoxGraphicsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTextureCache)).BeginInit();
            this.tabCustomTools.SuspendLayout();
            this.groupBoxFijiPath.SuspendLayout();
            this.groupBoxPythonPath.SuspendLayout();
            this.groupBoxXTFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImarisPath
            // 
            this.buttonImarisPath.Location = new System.Drawing.Point(11, 42);
            this.buttonImarisPath.Name = "buttonImarisPath";
            this.buttonImarisPath.Size = new System.Drawing.Size(492, 32);
            this.buttonImarisPath.TabIndex = 0;
            this.buttonImarisPath.Text = "...";
            this.buttonImarisPath.UseVisualStyleBackColor = true;
            this.buttonImarisPath.Click += new System.EventHandler(this.buttonImarisPath_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(447, 3);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(25, 25);
            this.buttonAbout.TabIndex = 8;
            this.buttonAbout.Text = "A";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(478, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(25, 25);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelExpl
            // 
            this.labelExpl.AutoSize = true;
            this.labelExpl.Location = new System.Drawing.Point(11, 15);
            this.labelExpl.Name = "labelExpl";
            this.labelExpl.Size = new System.Drawing.Size(283, 13);
            this.labelExpl.TabIndex = 10;
            this.labelExpl.Text = "Click here to choose the Imaris executable to manage:";
            // 
            // labelProductsText
            // 
            this.labelProductsText.AutoSize = true;
            this.labelProductsText.Location = new System.Drawing.Point(3, 13);
            this.labelProductsText.Name = "labelProductsText";
            this.labelProductsText.Size = new System.Drawing.Size(301, 13);
            this.labelProductsText.TabIndex = 11;
            this.labelProductsText.Text = "Choose the products that will be visible in ImarisSelector:";
            // 
            // checkedListBoxProducts
            // 
            this.checkedListBoxProducts.CheckOnClick = true;
            this.checkedListBoxProducts.FormattingEnabled = true;
            this.checkedListBoxProducts.Location = new System.Drawing.Point(6, 37);
            this.checkedListBoxProducts.Name = "checkedListBoxProducts";
            this.checkedListBoxProducts.Size = new System.Drawing.Size(466, 276);
            this.checkedListBoxProducts.TabIndex = 1;
            this.checkedListBoxProducts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxProducts_SelectedIndexChanged);
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Location = new System.Drawing.Point(11, 354);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(0, 13);
            this.labelProductDescription.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(14, 442);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(486, 39);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabModules);
            this.tabControl.Controls.Add(this.tabCache);
            this.tabControl.Controls.Add(this.tabCustomTools);
            this.tabControl.Location = new System.Drawing.Point(14, 81);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(486, 355);
            this.tabControl.TabIndex = 10;
            // 
            // tabModules
            // 
            this.tabModules.Controls.Add(this.labelProductsText);
            this.tabModules.Controls.Add(this.checkedListBoxProducts);
            this.tabModules.Location = new System.Drawing.Point(4, 22);
            this.tabModules.Name = "tabModules";
            this.tabModules.Padding = new System.Windows.Forms.Padding(3);
            this.tabModules.Size = new System.Drawing.Size(478, 329);
            this.tabModules.TabIndex = 0;
            this.tabModules.Text = "Modules";
            this.tabModules.UseVisualStyleBackColor = true;
            // 
            // tabCache
            // 
            this.tabCache.Controls.Add(this.groupBoxCacheFilePaths);
            this.tabCache.Controls.Add(this.groupBoxDataCache);
            this.tabCache.Controls.Add(this.groupBoxGraphicsCard);
            this.tabCache.Controls.Add(this.labelDataCachesText);
            this.tabCache.Controls.Add(this.labelCalculation);
            this.tabCache.Controls.Add(this.labelGraphicsCard);
            this.tabCache.Location = new System.Drawing.Point(4, 22);
            this.tabCache.Name = "tabCache";
            this.tabCache.Padding = new System.Windows.Forms.Padding(3);
            this.tabCache.Size = new System.Drawing.Size(478, 329);
            this.tabCache.TabIndex = 1;
            this.tabCache.Text = "Data/Texture Caches";
            this.tabCache.UseVisualStyleBackColor = true;
            // 
            // groupBoxCacheFilePaths
            // 
            this.groupBoxCacheFilePaths.Controls.Add(this.labelDataCachePathInfo);
            this.groupBoxCacheFilePaths.Controls.Add(this.buttonCLFileCachePathsAdd);
            this.groupBoxCacheFilePaths.Controls.Add(this.buttonCLFileCachePathsRemove);
            this.groupBoxCacheFilePaths.Controls.Add(this.listCLFileCachePaths);
            this.groupBoxCacheFilePaths.Location = new System.Drawing.Point(8, 223);
            this.groupBoxCacheFilePaths.Name = "groupBoxCacheFilePaths";
            this.groupBoxCacheFilePaths.Size = new System.Drawing.Size(455, 98);
            this.groupBoxCacheFilePaths.TabIndex = 26;
            this.groupBoxCacheFilePaths.TabStop = false;
            this.groupBoxCacheFilePaths.Text = "Cache File Paths";
            // 
            // labelDataCachePathInfo
            // 
            this.labelDataCachePathInfo.AutoSize = true;
            this.labelDataCachePathInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDataCachePathInfo.Location = new System.Drawing.Point(8, 80);
            this.labelDataCachePathInfo.Name = "labelDataCachePathInfo";
            this.labelDataCachePathInfo.Size = new System.Drawing.Size(307, 13);
            this.labelDataCachePathInfo.TabIndex = 22;
            this.labelDataCachePathInfo.Text = "Preferences > Calculation > Data Cache > File Cache Paths";
            // 
            // buttonCLFileCachePathsAdd
            // 
            this.buttonCLFileCachePathsAdd.Location = new System.Drawing.Point(413, 21);
            this.buttonCLFileCachePathsAdd.Name = "buttonCLFileCachePathsAdd";
            this.buttonCLFileCachePathsAdd.Size = new System.Drawing.Size(35, 25);
            this.buttonCLFileCachePathsAdd.TabIndex = 6;
            this.buttonCLFileCachePathsAdd.Text = "+";
            this.buttonCLFileCachePathsAdd.UseVisualStyleBackColor = true;
            this.buttonCLFileCachePathsAdd.Click += new System.EventHandler(this.buttonCLFileCachePathsAdd_Click);
            // 
            // buttonCLFileCachePathsRemove
            // 
            this.buttonCLFileCachePathsRemove.Location = new System.Drawing.Point(413, 52);
            this.buttonCLFileCachePathsRemove.Name = "buttonCLFileCachePathsRemove";
            this.buttonCLFileCachePathsRemove.Size = new System.Drawing.Size(35, 25);
            this.buttonCLFileCachePathsRemove.TabIndex = 7;
            this.buttonCLFileCachePathsRemove.Text = "-";
            this.buttonCLFileCachePathsRemove.UseVisualStyleBackColor = true;
            this.buttonCLFileCachePathsRemove.Click += new System.EventHandler(this.buttonCLFileCachePathsRemove_Click);
            // 
            // listCLFileCachePaths
            // 
            this.listCLFileCachePaths.FormattingEnabled = true;
            this.listCLFileCachePaths.Location = new System.Drawing.Point(8, 21);
            this.listCLFileCachePaths.Name = "listCLFileCachePaths";
            this.listCLFileCachePaths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCLFileCachePaths.Size = new System.Drawing.Size(400, 56);
            this.listCLFileCachePaths.TabIndex = 8;
            // 
            // groupBoxDataCache
            // 
            this.groupBoxDataCache.Controls.Add(this.numericDataCache);
            this.groupBoxDataCache.Controls.Add(this.labelCLDataCacheSize);
            this.groupBoxDataCache.Controls.Add(this.labelDataCacheSizeInfo);
            this.groupBoxDataCache.Location = new System.Drawing.Point(7, 154);
            this.groupBoxDataCache.Name = "groupBoxDataCache";
            this.groupBoxDataCache.Size = new System.Drawing.Size(457, 61);
            this.groupBoxDataCache.TabIndex = 25;
            this.groupBoxDataCache.TabStop = false;
            this.groupBoxDataCache.Text = "Memory";
            // 
            // numericDataCache
            // 
            this.numericDataCache.Increment = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericDataCache.Location = new System.Drawing.Point(348, 19);
            this.numericDataCache.Maximum = new decimal(new int[] {
            131072,
            0,
            0,
            0});
            this.numericDataCache.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericDataCache.Name = "numericDataCache";
            this.numericDataCache.Size = new System.Drawing.Size(101, 22);
            this.numericDataCache.TabIndex = 5;
            this.numericDataCache.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericDataCache.ValueChanged += new System.EventHandler(this.numericDataCache_ValueChanged);
            // 
            // labelCLDataCacheSize
            // 
            this.labelCLDataCacheSize.AutoSize = true;
            this.labelCLDataCacheSize.Location = new System.Drawing.Point(6, 21);
            this.labelCLDataCacheSize.Name = "labelCLDataCacheSize";
            this.labelCLDataCacheSize.Size = new System.Drawing.Size(99, 13);
            this.labelCLDataCacheSize.TabIndex = 20;
            this.labelCLDataCacheSize.Text = "Memory limit (MB)";
            this.labelCLDataCacheSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDataCacheSizeInfo
            // 
            this.labelDataCacheSizeInfo.AutoSize = true;
            this.labelDataCacheSizeInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDataCacheSizeInfo.Location = new System.Drawing.Point(6, 41);
            this.labelDataCacheSizeInfo.Name = "labelDataCacheSizeInfo";
            this.labelDataCacheSizeInfo.Size = new System.Drawing.Size(292, 13);
            this.labelDataCacheSizeInfo.TabIndex = 23;
            this.labelDataCacheSizeInfo.Text = "Preferences > Calculation > Data Cache > Memory Limit";
            // 
            // groupBoxGraphicsCard
            // 
            this.groupBoxGraphicsCard.Controls.Add(this.numericTextureCache);
            this.groupBoxGraphicsCard.Controls.Add(this.labelTextureCacheLabel);
            this.groupBoxGraphicsCard.Controls.Add(this.labelGraphicsCardInfo);
            this.groupBoxGraphicsCard.Location = new System.Drawing.Point(7, 58);
            this.groupBoxGraphicsCard.Name = "groupBoxGraphicsCard";
            this.groupBoxGraphicsCard.Size = new System.Drawing.Size(456, 65);
            this.groupBoxGraphicsCard.TabIndex = 24;
            this.groupBoxGraphicsCard.TabStop = false;
            this.groupBoxGraphicsCard.Text = "Texture cache";
            // 
            // numericTextureCache
            // 
            this.numericTextureCache.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericTextureCache.Location = new System.Drawing.Point(348, 15);
            this.numericTextureCache.Maximum = new decimal(new int[] {
            131072,
            0,
            0,
            0});
            this.numericTextureCache.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericTextureCache.Name = "numericTextureCache";
            this.numericTextureCache.Size = new System.Drawing.Size(101, 22);
            this.numericTextureCache.TabIndex = 4;
            this.numericTextureCache.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericTextureCache.ValueChanged += new System.EventHandler(this.numericTextureCache_ValueChanged);
            // 
            // labelTextureCacheLabel
            // 
            this.labelTextureCacheLabel.AutoSize = true;
            this.labelTextureCacheLabel.Location = new System.Drawing.Point(6, 23);
            this.labelTextureCacheLabel.Name = "labelTextureCacheLabel";
            this.labelTextureCacheLabel.Size = new System.Drawing.Size(53, 13);
            this.labelTextureCacheLabel.TabIndex = 0;
            this.labelTextureCacheLabel.Text = "Size (MB)";
            this.labelTextureCacheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGraphicsCardInfo
            // 
            this.labelGraphicsCardInfo.AutoSize = true;
            this.labelGraphicsCardInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelGraphicsCardInfo.Location = new System.Drawing.Point(6, 46);
            this.labelGraphicsCardInfo.Name = "labelGraphicsCardInfo";
            this.labelGraphicsCardInfo.Size = new System.Drawing.Size(229, 13);
            this.labelGraphicsCardInfo.TabIndex = 21;
            this.labelGraphicsCardInfo.Text = "Preferences > Display > Texture Cache Limit";
            // 
            // labelDataCachesText
            // 
            this.labelDataCachesText.AutoSize = true;
            this.labelDataCachesText.Location = new System.Drawing.Point(3, 13);
            this.labelDataCachesText.Name = "labelDataCachesText";
            this.labelDataCachesText.Size = new System.Drawing.Size(244, 13);
            this.labelDataCachesText.TabIndex = 16;
            this.labelDataCachesText.Text = "Set the user preferences you want to override:";
            // 
            // labelCalculation
            // 
            this.labelCalculation.BackColor = System.Drawing.Color.LightGray;
            this.labelCalculation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculation.Location = new System.Drawing.Point(3, 131);
            this.labelCalculation.Name = "labelCalculation";
            this.labelCalculation.Size = new System.Drawing.Size(468, 15);
            this.labelCalculation.TabIndex = 13;
            this.labelCalculation.Text = "Data Cache";
            this.labelCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGraphicsCard
            // 
            this.labelGraphicsCard.BackColor = System.Drawing.Color.LightGray;
            this.labelGraphicsCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraphicsCard.Location = new System.Drawing.Point(3, 35);
            this.labelGraphicsCard.Name = "labelGraphicsCard";
            this.labelGraphicsCard.Size = new System.Drawing.Size(468, 15);
            this.labelGraphicsCard.TabIndex = 12;
            this.labelGraphicsCard.Text = "Graphics Card";
            this.labelGraphicsCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabCustomTools
            // 
            this.tabCustomTools.Controls.Add(this.groupBoxFijiPath);
            this.tabCustomTools.Controls.Add(this.groupBoxPythonPath);
            this.tabCustomTools.Controls.Add(this.groupBoxXTFolders);
            this.tabCustomTools.Controls.Add(this.labelCustomTools);
            this.tabCustomTools.Controls.Add(this.labelCustomToolsText);
            this.tabCustomTools.Location = new System.Drawing.Point(4, 22);
            this.tabCustomTools.Name = "tabCustomTools";
            this.tabCustomTools.Size = new System.Drawing.Size(478, 329);
            this.tabCustomTools.TabIndex = 2;
            this.tabCustomTools.Text = "Custom Tools";
            this.tabCustomTools.UseVisualStyleBackColor = true;
            // 
            // groupBoxFijiPath
            // 
            this.groupBoxFijiPath.Controls.Add(this.labelFijiPathInfo);
            this.groupBoxFijiPath.Controls.Add(this.buttonCTRemFijiPath);
            this.groupBoxFijiPath.Controls.Add(this.buttonCTAddFijiPath);
            this.groupBoxFijiPath.Location = new System.Drawing.Point(10, 228);
            this.groupBoxFijiPath.Name = "groupBoxFijiPath";
            this.groupBoxFijiPath.Size = new System.Drawing.Size(456, 67);
            this.groupBoxFijiPath.TabIndex = 31;
            this.groupBoxFijiPath.TabStop = false;
            this.groupBoxFijiPath.Text = "ImageJ/Fiji Path";
            // 
            // labelFijiPathInfo
            // 
            this.labelFijiPathInfo.AutoSize = true;
            this.labelFijiPathInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelFijiPathInfo.Location = new System.Drawing.Point(9, 48);
            this.labelFijiPathInfo.Name = "labelFijiPathInfo";
            this.labelFijiPathInfo.Size = new System.Drawing.Size(175, 13);
            this.labelFijiPathInfo.TabIndex = 25;
            this.labelFijiPathInfo.Text = "Preferences > CustomTools > Fiji";
            // 
            // buttonCTRemFijiPath
            // 
            this.buttonCTRemFijiPath.Location = new System.Drawing.Point(416, 20);
            this.buttonCTRemFijiPath.Name = "buttonCTRemFijiPath";
            this.buttonCTRemFijiPath.Size = new System.Drawing.Size(35, 25);
            this.buttonCTRemFijiPath.TabIndex = 17;
            this.buttonCTRemFijiPath.Text = "-";
            this.buttonCTRemFijiPath.UseVisualStyleBackColor = true;
            this.buttonCTRemFijiPath.Click += new System.EventHandler(this.buttonCTRemFijiPath_Click);
            // 
            // buttonCTAddFijiPath
            // 
            this.buttonCTAddFijiPath.Location = new System.Drawing.Point(9, 20);
            this.buttonCTAddFijiPath.Name = "buttonCTAddFijiPath";
            this.buttonCTAddFijiPath.Size = new System.Drawing.Size(400, 25);
            this.buttonCTAddFijiPath.TabIndex = 16;
            this.buttonCTAddFijiPath.Text = "...";
            this.buttonCTAddFijiPath.UseVisualStyleBackColor = true;
            this.buttonCTAddFijiPath.Click += new System.EventHandler(this.buttonCTAddFijiPath_Click);
            // 
            // groupBoxPythonPath
            // 
            this.groupBoxPythonPath.Controls.Add(this.labelPythonPathInfo);
            this.groupBoxPythonPath.Controls.Add(this.buttonCTRemPythonPath);
            this.groupBoxPythonPath.Controls.Add(this.buttonCTAddPythonPath);
            this.groupBoxPythonPath.Location = new System.Drawing.Point(10, 156);
            this.groupBoxPythonPath.Name = "groupBoxPythonPath";
            this.groupBoxPythonPath.Size = new System.Drawing.Size(456, 67);
            this.groupBoxPythonPath.TabIndex = 30;
            this.groupBoxPythonPath.TabStop = false;
            this.groupBoxPythonPath.Text = "Python Path";
            // 
            // labelPythonPathInfo
            // 
            this.labelPythonPathInfo.AutoSize = true;
            this.labelPythonPathInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPythonPathInfo.Location = new System.Drawing.Point(9, 49);
            this.labelPythonPathInfo.Name = "labelPythonPathInfo";
            this.labelPythonPathInfo.Size = new System.Drawing.Size(196, 13);
            this.labelPythonPathInfo.TabIndex = 24;
            this.labelPythonPathInfo.Text = "Preferences > CustomTools > Python";
            // 
            // buttonCTRemPythonPath
            // 
            this.buttonCTRemPythonPath.Location = new System.Drawing.Point(416, 21);
            this.buttonCTRemPythonPath.Name = "buttonCTRemPythonPath";
            this.buttonCTRemPythonPath.Size = new System.Drawing.Size(35, 25);
            this.buttonCTRemPythonPath.TabIndex = 15;
            this.buttonCTRemPythonPath.Text = "-";
            this.buttonCTRemPythonPath.UseVisualStyleBackColor = true;
            this.buttonCTRemPythonPath.Click += new System.EventHandler(this.buttonCTRemPythonPath_Click);
            // 
            // buttonCTAddPythonPath
            // 
            this.buttonCTAddPythonPath.Location = new System.Drawing.Point(9, 21);
            this.buttonCTAddPythonPath.Name = "buttonCTAddPythonPath";
            this.buttonCTAddPythonPath.Size = new System.Drawing.Size(400, 25);
            this.buttonCTAddPythonPath.TabIndex = 14;
            this.buttonCTAddPythonPath.Text = "...";
            this.buttonCTAddPythonPath.UseVisualStyleBackColor = true;
            this.buttonCTAddPythonPath.Click += new System.EventHandler(this.buttonCTAddPythonPath_Click);
            // 
            // groupBoxXTFolders
            // 
            this.groupBoxXTFolders.Controls.Add(this.labelXTFoldersInfo);
            this.groupBoxXTFolders.Controls.Add(this.listCTXTPaths);
            this.groupBoxXTFolders.Controls.Add(this.buttonCTXTPathsAdd);
            this.groupBoxXTFolders.Controls.Add(this.buttonCTXTPathsRemove);
            this.groupBoxXTFolders.Location = new System.Drawing.Point(10, 55);
            this.groupBoxXTFolders.Name = "groupBoxXTFolders";
            this.groupBoxXTFolders.Size = new System.Drawing.Size(456, 96);
            this.groupBoxXTFolders.TabIndex = 29;
            this.groupBoxXTFolders.TabStop = false;
            this.groupBoxXTFolders.Text = "XTension Folders";
            // 
            // labelXTFoldersInfo
            // 
            this.labelXTFoldersInfo.AutoSize = true;
            this.labelXTFoldersInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelXTFoldersInfo.Location = new System.Drawing.Point(6, 77);
            this.labelXTFoldersInfo.Name = "labelXTFoldersInfo";
            this.labelXTFoldersInfo.Size = new System.Drawing.Size(247, 13);
            this.labelXTFoldersInfo.TabIndex = 23;
            this.labelXTFoldersInfo.Text = "Preferences > CustomTools > XTension Folders";
            // 
            // listCTXTPaths
            // 
            this.listCTXTPaths.FormattingEnabled = true;
            this.listCTXTPaths.Location = new System.Drawing.Point(9, 18);
            this.listCTXTPaths.Name = "listCTXTPaths";
            this.listCTXTPaths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCTXTPaths.Size = new System.Drawing.Size(400, 56);
            this.listCTXTPaths.TabIndex = 13;
            // 
            // buttonCTXTPathsAdd
            // 
            this.buttonCTXTPathsAdd.Location = new System.Drawing.Point(416, 18);
            this.buttonCTXTPathsAdd.Name = "buttonCTXTPathsAdd";
            this.buttonCTXTPathsAdd.Size = new System.Drawing.Size(35, 25);
            this.buttonCTXTPathsAdd.TabIndex = 11;
            this.buttonCTXTPathsAdd.Text = "+";
            this.buttonCTXTPathsAdd.UseVisualStyleBackColor = true;
            this.buttonCTXTPathsAdd.Click += new System.EventHandler(this.buttonCTXTPathsAdd_Click);
            // 
            // buttonCTXTPathsRemove
            // 
            this.buttonCTXTPathsRemove.Location = new System.Drawing.Point(416, 49);
            this.buttonCTXTPathsRemove.Name = "buttonCTXTPathsRemove";
            this.buttonCTXTPathsRemove.Size = new System.Drawing.Size(35, 25);
            this.buttonCTXTPathsRemove.TabIndex = 12;
            this.buttonCTXTPathsRemove.Text = "-";
            this.buttonCTXTPathsRemove.UseVisualStyleBackColor = true;
            this.buttonCTXTPathsRemove.Click += new System.EventHandler(this.buttonCTXTPathsRemove_Click);
            // 
            // labelCustomTools
            // 
            this.labelCustomTools.BackColor = System.Drawing.Color.LightGray;
            this.labelCustomTools.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomTools.Location = new System.Drawing.Point(3, 35);
            this.labelCustomTools.Name = "labelCustomTools";
            this.labelCustomTools.Size = new System.Drawing.Size(468, 15);
            this.labelCustomTools.TabIndex = 27;
            this.labelCustomTools.Text = "Custom paths";
            this.labelCustomTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomToolsText
            // 
            this.labelCustomToolsText.AutoSize = true;
            this.labelCustomToolsText.Location = new System.Drawing.Point(3, 13);
            this.labelCustomToolsText.Name = "labelCustomToolsText";
            this.labelCustomToolsText.Size = new System.Drawing.Size(244, 13);
            this.labelCustomToolsText.TabIndex = 17;
            this.labelCustomToolsText.Text = "Set the user preferences you want to override:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 493);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelProductDescription);
            this.Controls.Add(this.labelExpl);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonImarisPath);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "ImarisSelector :: Admin";
            this.tabControl.ResumeLayout(false);
            this.tabModules.ResumeLayout(false);
            this.tabModules.PerformLayout();
            this.tabCache.ResumeLayout(false);
            this.tabCache.PerformLayout();
            this.groupBoxCacheFilePaths.ResumeLayout(false);
            this.groupBoxCacheFilePaths.PerformLayout();
            this.groupBoxDataCache.ResumeLayout(false);
            this.groupBoxDataCache.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDataCache)).EndInit();
            this.groupBoxGraphicsCard.ResumeLayout(false);
            this.groupBoxGraphicsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTextureCache)).EndInit();
            this.tabCustomTools.ResumeLayout(false);
            this.tabCustomTools.PerformLayout();
            this.groupBoxFijiPath.ResumeLayout(false);
            this.groupBoxFijiPath.PerformLayout();
            this.groupBoxPythonPath.ResumeLayout(false);
            this.groupBoxPythonPath.PerformLayout();
            this.groupBoxXTFolders.ResumeLayout(false);
            this.groupBoxXTFolders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImarisPath;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelExpl;
        private System.Windows.Forms.Label labelProductsText;
        private System.Windows.Forms.CheckedListBox checkedListBoxProducts;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabModules;
        private System.Windows.Forms.TabPage tabCache;
        private System.Windows.Forms.ListBox listCLFileCachePaths;
        private System.Windows.Forms.Button buttonCLFileCachePathsRemove;
        private System.Windows.Forms.Button buttonCLFileCachePathsAdd;
        private System.Windows.Forms.Label labelGraphicsCard;
        private System.Windows.Forms.Label labelCalculation;
        private System.Windows.Forms.Label labelDataCachesText;
        private System.Windows.Forms.Label labelCLDataCacheSize;
        private System.Windows.Forms.TabPage tabCustomTools;
        private System.Windows.Forms.Label labelCustomToolsText;
        private System.Windows.Forms.Label labelTextureCacheLabel;
        private System.Windows.Forms.Button buttonCTAddFijiPath;
        private System.Windows.Forms.Button buttonCTRemFijiPath;
        private System.Windows.Forms.Button buttonCTAddPythonPath;
        private System.Windows.Forms.Button buttonCTRemPythonPath;
        private System.Windows.Forms.Label labelCustomTools;
        private System.Windows.Forms.ListBox listCTXTPaths;
        private System.Windows.Forms.Button buttonCTXTPathsRemove;
        private System.Windows.Forms.Button buttonCTXTPathsAdd;
        private System.Windows.Forms.Label labelGraphicsCardInfo;
        private System.Windows.Forms.Label labelDataCacheSizeInfo;
        private System.Windows.Forms.Label labelDataCachePathInfo;
        private System.Windows.Forms.GroupBox groupBoxXTFolders;
        private System.Windows.Forms.Label labelXTFoldersInfo;
        private System.Windows.Forms.GroupBox groupBoxFijiPath;
        private System.Windows.Forms.GroupBox groupBoxPythonPath;
        private System.Windows.Forms.Label labelPythonPathInfo;
        private System.Windows.Forms.GroupBox groupBoxGraphicsCard;
        private System.Windows.Forms.Label labelFijiPathInfo;
        private System.Windows.Forms.GroupBox groupBoxDataCache;
        private System.Windows.Forms.GroupBox groupBoxCacheFilePaths;
        private System.Windows.Forms.NumericUpDown numericTextureCache;
        private System.Windows.Forms.NumericUpDown numericDataCache;
    }
}

