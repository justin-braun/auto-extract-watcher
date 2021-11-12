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
        private string? Location = "";
        FileSystemWatcher? watcher;

        public Watcher(string directory)
        {
            Location = directory;

            watcher = new FileSystemWatcher();
            watcher.Path = directory;

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

                string extractDestinationRoot = $@"{Location}\{fileName.Substring(0, fileName.LastIndexOf("."))}";
                string extractDestinationPath = extractDestinationRoot;
                int i = 2;
                while (Directory.Exists(extractDestinationPath))
                {
                    extractDestinationPath = $"{extractDestinationRoot}{i}";
                    i++;
                }

                if (!extractDestinationPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
                    extractDestinationPath += Path.DirectorySeparatorChar;

                ZipFile.ExtractToDirectory(fullPath, extractDestinationPath);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
