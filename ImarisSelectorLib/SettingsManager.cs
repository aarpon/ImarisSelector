using System;
using System.IO;
using System.Collections.Generic;

namespace ImarisSelectorLib
{
    /// <summary>
    /// Simple class to hold the settings.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Imaris version in the form "Imaris x64 7.7" (no patch version).
        /// </summary>
        public String ImarisVersion { get; set; }

        /// <summary>
        /// Full path of the Imaris executable.
        /// </summary>
        public String ImarisPath { get; set; }

        /// <summary>
        /// List of product names with their enabled state.
        /// </summary>
        public Dictionary<String, bool> ProductsWithEnabledState { get; set; }

        /// <summary>
        /// True if the Settings is valid (i.e. all fields are defined and valid).
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Graphics card texture cache in MB.
        /// </summary>
        public int TextureCache { get; set; }

        /// <summary>
        /// Data block cache in MB.
        /// </summary>
        public int DataCache { get; set; }

        /// <summary>
        /// Data block caching file paths (semicolon-separated).
        /// </summary>
        public String DataBlockCachingFilePath { get; set; }

        /// <summary>
        /// XT folder paths (semicolon-separated).
        /// </summary>
        public String XTFolderPath { get; set; }

        /// <summary>
        /// Python executable path.
        /// </summary>
        public String PythonPath { get; set; }

        /// <summary>
        /// Fiji executable path.
        /// </summary>
        public String FijiPath { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Settings()
        {
            // Set defaults to values that will not override
            // anything in the registry.
            ImarisVersion = "";
            ImarisPath = "";
            ProductsWithEnabledState = new Dictionary<String, bool>();
            IsValid = false;
            TextureCache = -1;
            DataCache = -1;
            DataBlockCachingFilePath = "";
            XTFolderPath = "";
            PythonPath = "";
            FijiPath = "";
        }
    }

    /// <summary>
    /// Static class to manage the ImarisSelector settings.
    /// </summary>
    public static class SettingsManager
    {
        /// <summary>
        /// Get the ImarisSelector settings from the settings file.
        /// </summary>
        /// <returns>A Settings object with the loaded settings.</returns>
        public static Settings read()
        {
            // Initialize output
            Settings settings = new Settings();

            // Does the settings file exist?
            if (File.Exists(settingsFullFileName()))
            {
                // Read the settings file
                // First line is the header, the second is ImarisVersion, the third is ImarisPath
                StreamReader file = new System.IO.StreamReader(settingsFullFileName());
                if (file != null)
                {
                    String line;
                    while ((line = file.ReadLine()) != null)
                    {
                        // Get the line key and value
                        String[] parts = line.Split('=');

                        if (parts.Length != 2)
                        {
                            continue;
                        }

                        // FileVersion is the first entry in the file
                        if (parts[0].Equals("FileVersion"))
                        {
                            String fileVersion = parts[1];
                            bool isNewest = false;
                            bool isCompatible = false;
                            IsNewestVersion(fileVersion, out isNewest, out isCompatible);

                            if (!isNewest & !isCompatible)
                            {
                                // Invalid settings file version - ignore the file
                                return new Settings();
                            }
                        }
                        else if (parts[0].Equals("ImarisVersion"))
                        {
                            settings.ImarisVersion = parts[1];
                        }
                        else if (parts[0].Equals("ImarisPath"))
                        {
                            settings.ImarisPath = parts[1];
                        }
                        else if (parts[0].Equals("TextureCache"))
                        {
                            settings.TextureCache = int.Parse(parts[1]);
                        }
                        else if (parts[0].Equals("DataCache"))
                        {
                            settings.DataCache = int.Parse(parts[1]);
                        }
                        else if (parts[0].Equals("DataBlockCachingFilePath"))
                        {
                            settings.DataBlockCachingFilePath = parts[1];
                        }
                        else if (parts[0].Equals("XTFolderPath"))
                        {
                            settings.XTFolderPath = parts[1];
                        }
                        else if (parts[0].Equals("PythonPath"))
                        {
                            settings.PythonPath = parts[1];
                        }
                        else if (parts[0].Equals("FijiPath"))
                        {
                            settings.FijiPath = parts[1];
                        }
                        else
                        {
                            settings.ProductsWithEnabledState.Add(parts[0], parts[1].Equals("true"));
                        }
                    }
                    file.Close();
                }
            }

            // Now check (not all settings are mandatory)
            if (!settings.ImarisVersion.Equals("") && !settings.ImarisPath.Equals("") &&
                settings.ProductsWithEnabledState.Count > 0)
            {
                settings.IsValid = true;
            }
            else
            {
                settings.IsValid = false;
            }

            // Return the settings
            return settings;
        }

        /// <summary>
        /// Set the application settings to the settings file.
        /// </summary>
        /// <param name="settings">A Settings object with the settings to write to disk.</param>
        /// <returns>True if the settings could be saved to disk, false otherwise.</returns>
        public static bool write(Settings settings)
        {
            // We put the whole writing block in a try...catch block
            try
            {

                // Make sure the settings directory exists
                CreateSettingsDirIfNeeded(SettingsDirectoryName());

                // Write the settings to file
                StreamWriter file = new StreamWriter(settingsFullFileName());
                if (file != null)
                {
                    file.WriteLine("FileVersion=ImarisSelector Settings File version 2");
                    file.WriteLine("ImarisVersion=" + settings.ImarisVersion);
                    file.WriteLine("ImarisPath=" + settings.ImarisPath);
                    file.WriteLine("TextureCache=" + settings.TextureCache);
                    file.WriteLine("DataCache=" + settings.DataCache);
                    file.WriteLine("DataBlockCachingFilePath=" + settings.DataBlockCachingFilePath);
                    file.WriteLine("XTFolderPath=" + settings.XTFolderPath);
                    file.WriteLine("PythonPath=" + settings.PythonPath);
                    file.WriteLine("FijiPath=" + settings.FijiPath);
                    foreach (KeyValuePair<String, bool> entry in settings.ProductsWithEnabledState)
                    {
                        String state = "false";
                        if (entry.Value == true)
                        {
                            state = "true";
                        }
                        file.WriteLine(entry.Key + "=" + state);
                    }
                    file.Close();

                    // Success
                    return true;
                }
                else
                {
                    // Failure
                    return false;
                }
            }
            catch
            {
                // Could not write to disk!
                return false;
            }

        }

        /// <summary>
        /// Returns the full path fo the settings directory.
        /// </summary>
        /// <returns>Full path of the settings directory.</returns>
        private static String SettingsDirectoryName()
        {
            // Get the commonAppData path
            String commonAppData = Environment.GetFolderPath(
                Environment.SpecialFolder.CommonApplicationData);

            // Append the ImarisSelector path
            return commonAppData + @"\ImarisSelector\";
        }


        /// <summary>
        /// Returns the setting file name with full path.
        /// </summary>
        /// <returns>Setting file name with full path.</returns>
        private static String settingsFullFileName()
        {
            // Append the ImarisSelector path
            return SettingsDirectoryName() + @"settings.conf";
        }

        /// <summary>
        /// Create the specified directory if it does not exist.
        /// </summary>
        /// <param name="dir">Full directory name to be created.</param>
        private static void CreateSettingsDirIfNeeded(String dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        /// <summary>
        /// Checks whether the version of the Settings file is at the newest version and if not if it is
        /// compatible or if it must be discarded.
        /// </summary>
        /// <param name="versionStr">Version string as read from the file.</param>
        /// <param name="isNewest">True if the file is at the newest version, false otherwise. Please mind
        /// that this is an argument passed by reference!</param>
        /// <param name="isCompatible">True if the file is NOT at the newest version, but its content is 
        /// valid and usable in current version. If false, the content of the file should be discarded
        /// and an empty configuration should be used. Please mind that this is an argument passed by
        /// reference!</param>
        private static void IsNewestVersion(String versionStr, out bool isNewest, out bool isCompatible)
        {
            // From version 2 we change to a simpler, incremental (integer) version number.
            if (versionStr.Equals("ImarisSelector Settings File version 2"))
            {
                isNewest = true;
                isCompatible = true;
            }
            else if (versionStr.Equals("ImarisSelector Settings File version 1.0.0"))
            {
                isNewest = false;
                isCompatible = true;
            }
            else
            {
                isNewest = false;
                isCompatible = false;
            }
        }

    }
}
