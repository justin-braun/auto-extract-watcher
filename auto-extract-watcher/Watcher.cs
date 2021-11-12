using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Diagnostics;

namespace auto_extract_watcher
{
    internal class Watcher
    {
        private string? WatchDirectory = "";
        private string? ExtractDirectory = "";
        FileSystemWatcher? watcher;

        public Watcher(string watchDirectory, string extractDirectory)
        {
            WatchDirectory = watchDirectory;
            ExtractDirectory = extractDirectory;

            watcher = new FileSystemWatcher();
            watcher.Path = watchDirectory;

            watcher.IncludeSubdirectories = true;
            watcher.Filter = "*.zip";
            watcher.Created += Watcher_FileCreated;

        }

        public void StartWatching()
        {
            if (watcher != null)
            {
                // Start watching
                watcher.EnableRaisingEvents = true;
            }
        }

        public void StopWatching()
        {
            if (watcher != null)
            {
                // Stop watching
                watcher.EnableRaisingEvents = false;
            }
        }
        private void Watcher_FileCreated(object sender, FileSystemEventArgs e)
        {
            try
            {
                if(e.Name != null)
                {
                    ExtractToDirectory(e.FullPath, e.Name);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExtractToDirectory(string fullPath, string fileName)
        {
            // Try to extract the file to the directory of the same name
            try
            {
                string extractDestinationRoot = "";

                if(ExtractDirectory != "")
                {
                    // Use specified custom directory
                    extractDestinationRoot = $@"{ExtractDirectory}\{fileName.Substring(0, fileName.LastIndexOf("."))}";
                }
                else
                {
                    // Use the same directory as original file
                    extractDestinationRoot = $@"{WatchDirectory}\{fileName.Substring(0, fileName.LastIndexOf("."))}";
                }
                
                // We won't overwrite a duplicate directory, so rename the new folder with a counter if needed
                string extractDestinationPath = extractDestinationRoot;
                int i = 2;
                while (Directory.Exists(extractDestinationPath))
                {
                    extractDestinationPath = $"{extractDestinationRoot}{i}";
                    i++;
                }

                // Make sure trailing directory separator is included to prevent any malicious injection
                if (!extractDestinationPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
                    extractDestinationPath += Path.DirectorySeparatorChar;

                // Extract file
                ZipFile.ExtractToDirectory(fullPath, extractDestinationPath);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
