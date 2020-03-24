using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using w3botUninstaller.Utils;

namespace w3botUninstaller.Command
{
    public abstract class AbstractInputOutput
    {
        protected string DestinationPath { get; private set; }
        protected bool IsFinished { get; private set; } = false;
        protected static bool Running { get; private set; }
        protected bool IsCancelled { get; private set; }
        protected string FilePath { get; private set; } = "";

        public AbstractInputOutput(string path)
        {
            DestinationPath = path;
        }

        public void Remove(string destinationPath)
        {
            var destinationDirectory = new DirectoryInfo(destinationPath);

            //if (!destinationDirectory.Exists)
            //{
            //    IsFinished = true;
            //    return;
            //}

            Task.Run(() =>
            {
                if (destinationDirectory.GetFiles().Length > 0)
                    RemoveFiles(destinationDirectory, destinationPath);

                if (destinationDirectory.GetDirectories().Length > 0)
                    RemoveDirectories(destinationDirectory, destinationPath);

                if (!Directory.EnumerateFileSystemEntries(destinationPath).Any())
                    Directory.Delete(destinationPath);

                IsFinished = true;
            });

            while (!IsFinished)
                Thread.Sleep(100);
        }

        private void RemoveDirectories(DirectoryInfo destinationDirectory, string destinationPath)
        {
            foreach (var directory in destinationDirectory.GetDirectories())
            {
                if (directory.Exists)
                    RemoveDirectories(directory, directory.FullName);

                if (directory.GetFiles().Length > 0)
                    RemoveFiles(directory, directory.FullName);

                Directory.Delete(directory.FullName);
            }
        }

        private void RemoveFiles(DirectoryInfo destinationDirectory, string destinationPath)
        {
            foreach (var file in destinationDirectory.GetFiles())
            {
                var fileName = file.Name;
                var path = GetFullPath(destinationPath, fileName);

                if (fileName == Application.ProductName)
                    return;

                FilePath = path;

                if (fileName == "w3botUninstaller.exe")
                    return;

                File.Delete(path);
            }
        }

        public string GetFullPath(string sourcePath, string destinationPath)
        {
            return String.Format(@"{0}\{1}", sourcePath, destinationPath);
        }
    }
}
