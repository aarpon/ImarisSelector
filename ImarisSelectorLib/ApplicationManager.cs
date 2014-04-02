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

        // PRIVATE METHODS
        /// <summary>
        /// Set the data block caching file paths to the registry
        /// </summary>
        /// <returns>true if setting the paths was successful, false otherwise</returns>
        private bool SetDataBlockCachingFilePaths(List<String> filePaths)
        {
            // Check that we have some file paths
            if (filePaths.Count == 0)
            {
                return false;
            }

            // Serialize the filePaths
            System.Text.StringBuilder serialFilePaths = new System.Text.StringBuilder();
            foreach (String filePath in filePaths)
            {
                serialFilePaths.Append(filePath);
            }

            // Get the HKEY_USERS tree
            RegistryKey reg = Registry.Users;

            // Get the Software key (writable)
            String dataBlockCachePath = this.m_RegistryManager.GetImarisKeyPath() +
                "\\DataBlockCaching\\";
            RegistryKey dataBlockCacheKey = reg.OpenSubKey(dataBlockCachePath, true);

            // Store the values
            dataBlockCacheKey.SetValue("FilePath", serialFilePaths, RegistryValueKind.String);

            // Return success
            return true;
        }

        /// <summary>
        /// Set the graphics texture cache size to the registry
        /// </summary>
        /// <returns>true if setting the cache size was successful, false otherwise</returns>
        private bool SetGraphicsTextureCacheSize(int cacheSize)
        {
            // Check that the cache size is a positive integer
            if (cacheSize < 1)
            {
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

            // Store the values
            graphicsPathKey.SetValue("TextureCacheSize", strCacheSize, RegistryValueKind.String);

            // Return success
            return true;
        }


    }
}
