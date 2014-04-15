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

            // Store the values
            customToolsKey.SetValue("MatlabRuntimePath", matlabRuntimePath, RegistryValueKind.String);
        }

    }
}
