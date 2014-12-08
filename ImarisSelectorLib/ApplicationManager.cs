using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Win32;

namespace ImarisSelectorLib
{

    /// <summary>
    /// A class to manage the Imaris application settings. 
    /// </summary>
    public class ApplicationManager
    {

        private Settings m_Settings;

        private RegistryManager m_RegistryManager;

        /// <summary>
        /// Constructor.
        /// <param name="settings">Application settings (read from disk).</param>
        /// </summary>
        public ApplicationManager(Settings settings)
        {
            // Store the settings
            this.m_Settings = settings;

            // Initialize the Registry Manager
            this.m_RegistryManager = new RegistryManager(this.m_Settings.ImarisVersion);

        }

        /// <summary>
        /// Stores all settings into the registry.
        /// </summary>
        public void store()
        {
            // If the Imaris section does not exist in the registry, we create it
            // so that the settings can be stored.
            CreateImarisRegistryRootKeyIfNeeded();

            // To prevent the configuration dialog to appear, we disable 
            // updates and usage monitor (they can be re-enabled by the user).
            DisableUpdates();
            DisableUsageLogger();
            DisableImarisOwnLicenseSelector();

            // Store the graphics card texture cache
            SetGraphicsTextureCacheSize(this.m_Settings.TextureCache);

            // Store the data block cache
            SetDataBlockCacheSize(this.m_Settings.DataCache);

            // Store the data block caching file paths
            SetDataBlockCachingFilePaths(this.m_Settings.DataBlockCachingFilePath);

            // Set the XT folder paths
            SetCustomToolsXTPaths(this.m_Settings.XTFolderPath);

            // Set the Python path
            SetCustomToolsPythonPath(this.m_Settings.PythonPath);

            // Set the Fiji path
            SetCustomToolsFijiPath(this.m_Settings.FijiPath);
        }

        // PRIVATE METHODS

        /// <summary>
        /// Create the Imaris key in the registry if needed.
        /// </summary>
        private void CreateImarisRegistryRootKeyIfNeeded()
        {
            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get or create the Imaris key
            String imarisKeyPath = this.m_RegistryManager.GetImarisKeyPath();
            RegistryKey imarisKey = reg.OpenSubKey(imarisKeyPath, true);
            if (imarisKey == null)
            {
                // The key does not exist. We create it.
                imarisKey = reg.CreateSubKey(imarisKeyPath);

            }
        }

        /// <summary>
        /// Disable updates.
        /// </summary>
        private void DisableUpdates()
        {
            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Settings key (writable)
            String settingsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\Settings\\";
            RegistryKey settingsPathKey = reg.OpenSubKey(settingsPath, true);
            if (settingsPathKey == null)
            {
                // If the key does not exist, we create it
                settingsPathKey = reg.CreateSubKey(settingsPath);
            }

            // Now write the values
            String date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss.000");
            settingsPathKey.SetValue("MaintenancePlanCheck", "never", RegistryValueKind.String);
            settingsPathKey.SetValue("MaintenancePlanCheckDate", date, RegistryValueKind.String);
            settingsPathKey.SetValue("UpdatesCheck", "never", RegistryValueKind.String);
            settingsPathKey.SetValue("UpdatesCheckDate", date, RegistryValueKind.String);
            settingsPathKey.SetValue("UpdatesCheckSkippedVersion", "0.0.0", RegistryValueKind.String);
        }

        /// <summary>
        /// Disable usage logger.
        /// </summary>
        private void DisableUsageLogger()
        {
            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the UsageLogger key (writable)
            String usageLoggerPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\UsageLogger\\";
            RegistryKey usageLoggerPathKey = reg.OpenSubKey(usageLoggerPath, true);
            if (usageLoggerPathKey == null)
            {
                // If the key does not exist, we create it
                usageLoggerPathKey = reg.CreateSubKey(usageLoggerPath);
            }

            // Now write the necessary values
            usageLoggerPathKey.SetValue("LogEnabled", "false", RegistryValueKind.String);
        }

        /// <summary>
        /// Disable Imaris own license manager. This only exists in Imaris 8 and newer.
        /// </summary>
        private void DisableImarisOwnLicenseSelector()
        {
            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Settings key (writable)
            String settingsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\Settings\\";
            RegistryKey settingsPathKey = reg.OpenSubKey(settingsPath, true);
            if (settingsPathKey != null)
            {
                // If the key exists, we disable the license manager. Otherwise, we just return.
                settingsPathKey.SetValue("ShowLicenseSelectionStartupDialog", "false", RegistryValueKind.String);
            }

        }

        /// <summary>
        /// Set the graphics texture cache size to the registry
        /// </summary>
        private void SetGraphicsTextureCacheSize(int cacheSize)
        {
            // Check that the cache size is set
            if (cacheSize == -1)
            {
                // The admin did not set it
                return;
            }

            // Check that the cache is a positive integer
            if (cacheSize < 1)
            {
                // This is a correct case
                throw new ArgumentException("cacheSize must be a positive integer.");
            }

            // We need a string representation of the cache size
            string strCacheSize = cacheSize.ToString();

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String graphicsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\Graphics\\";
            RegistryKey graphicsPathKey = reg.OpenSubKey(graphicsPath, true);
            if (graphicsPathKey == null)
            {
                // If the key does not exist, we create it
                graphicsPathKey = reg.CreateSubKey(graphicsPath);
            }

            // Store the values
            graphicsPathKey.SetValue("TextureCacheSize", strCacheSize, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the data block cache size to the registry
        /// </summary>
        private void SetDataBlockCacheSize(int cacheSize)
        {
            // Check that the cache size is set
            if (cacheSize == -1)
            {
                // The admin did not set it
                return;
            }

            // Check that the cache is a positive integer
            if (cacheSize < 1)
            {
                // This is a correct case
                throw new ArgumentException("cacheSize must be a positive integer.");
            }

            // We need a string representation of the cache size
            string strCacheSize = cacheSize.ToString();

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String graphicsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\DataBlockCaching\\";
            RegistryKey graphicsPathKey = reg.OpenSubKey(graphicsPath, true);
            if (graphicsPathKey == null)
            {
                // If the key does not exist, we create it
                graphicsPathKey = reg.CreateSubKey(graphicsPath);
            }

            // Store the values
            graphicsPathKey.SetValue("DataCacheSize", strCacheSize, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the data block caching file paths to the registry
        /// </summary>
        private void SetDataBlockCachingFilePaths(String filePaths)
        {
            // Check that we have some file paths
            if (filePaths.Equals(""))
            {
                // The admin did not set it
                return;
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String dataBlockCachePath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\DataBlockCaching\\";
            RegistryKey dataBlockCacheKey = reg.OpenSubKey(dataBlockCachePath, true);
            if (dataBlockCacheKey == null)
            {
                // If the key does not exist, we create it
                dataBlockCacheKey = reg.CreateSubKey(dataBlockCachePath);
            }

            // Store the values
            dataBlockCacheKey.SetValue("FilePath", filePaths, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the custom tools XT paths to the registry
        /// </summary>
        private void SetCustomToolsXTPaths(String filePaths)
        {
            // Check that we have some file paths
            if (filePaths.Equals(""))
            {
                // The admin did not set it
                return;
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String customToolsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\CustomTools\\";
            RegistryKey customToolsKey = reg.OpenSubKey(customToolsPath, true);
            if (customToolsKey == null)
            {
                // If the key does not exist, we create it
                customToolsKey = reg.CreateSubKey(customToolsPath);
            }

            // Store the values
            customToolsKey.SetValue("XTPath", filePaths, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the custom tools python paths to the registry
        /// </summary>
        private void SetCustomToolsPythonPath(String pythonPath)
        {
            // Check if the Python path is set
            if (pythonPath.Equals(""))
            {
                // The admin did not set it
                return;
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String customToolsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\CustomTools\\";
            RegistryKey customToolsKey = reg.OpenSubKey(customToolsPath, true);
            if (customToolsKey == null)
            {
                // If the key does not exist, we create it
                customToolsKey = reg.CreateSubKey(customToolsPath);
            }

            // Store the values
            customToolsKey.SetValue("PythonPath", pythonPath, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the custom tools Fiji paths to the registry
        /// </summary>
        private void SetCustomToolsFijiPath(String fijiPath)
        {
            // Check if the Python path is set
            if (fijiPath.Equals(""))
            {
                // The admin did not set it
                return;
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String customToolsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\CustomTools\\";
            RegistryKey customToolsKey = reg.OpenSubKey(customToolsPath, true);
            if (customToolsKey == null)
            {
                // If the key does not exist, we create it
                customToolsKey = reg.CreateSubKey(customToolsPath);
            }

            // Store the values
            customToolsKey.SetValue("FijiPath", fijiPath, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the custom tools MATLAB paths to the registry.
        /// 
        /// Note: this is not used, since in Windows the MATLAB path is not exposed.
        /// </summary>
        private void SetCustomToolsMATLABPath(String matlabPath)
        {
            // Check if the Python path is set
            if (matlabPath.Equals(""))
            {
                // The admin did not set it
                return;
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String customToolsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\CustomTools\\";
            RegistryKey customToolsKey = reg.OpenSubKey(customToolsPath, true);
            if (customToolsKey == null)
            {
                // If the key does not exist, we create it
                customToolsKey = reg.CreateSubKey(customToolsPath);
            }

            // Store the values
            customToolsKey.SetValue("MatlabPath", matlabPath, RegistryValueKind.String);
        }

        /// <summary>
        /// Set the custom tools MATLAB Runtime paths to the registry
        /// </summary>
        private void SetCustomToolsMATLABRuntimePath(String matlabRuntimePath)
        {
            // Check if the Python path is set
            if (matlabRuntimePath.Equals(""))
            {
                // The admin did not set it
                return;
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String customToolsPath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\CustomTools\\";
            RegistryKey customToolsKey = reg.OpenSubKey(customToolsPath, true);
            if (customToolsKey == null)
            {
                // If the key does not exist, we create it
                customToolsKey = reg.CreateSubKey(customToolsPath);
            }

            // Store the values
            customToolsKey.SetValue("MatlabRuntimePath", matlabRuntimePath, RegistryValueKind.String);
        }

    }
}
