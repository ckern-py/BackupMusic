using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace MoveFilesBackup
{
    class DirectoryMusic
    {
        Regex regexSongFileEndings = new Regex(@"(\..{3,4})$");

        //Walks directory and returns list of all files and folders
        public List<string> WalkDirectory(string currentDirectory)
        {
            List<string> currentDirectoryFiles = new List<string>();

            foreach (string files in Directory.EnumerateFileSystemEntries(currentDirectory, "*.*", SearchOption.AllDirectories))
            {
                string noSourceDir = files.Remove(0, currentDirectory.Length);
                currentDirectoryFiles.Add(noSourceDir);
            }

            return currentDirectoryFiles;
        }

        //Create folders by finding list objects with no extensions
        public void CreateFolders(List<string> directoryFiles, string targetDirectory)
        {
            foreach (string missingFiles in directoryFiles)
            {
                if (!regexSongFileEndings.IsMatch(missingFiles))
                {
                    Directory.CreateDirectory((targetDirectory + missingFiles));
                    Console.WriteLine(missingFiles);
                }
            }

        }

        //Copies files to the correct folder in the target directory
        public void CopyFiles(List<string> missingDirectoryFiles, string sourceDirectory, string targetDirectory)
        {
            foreach (string missingFiles in missingDirectoryFiles)
            {
                if (regexSongFileEndings.IsMatch(missingFiles))
                {
                    string fullFilePath = sourceDirectory + missingFiles;
                    FileInfo songToMove = new FileInfo(fullFilePath);
                    songToMove.CopyTo((targetDirectory + missingFiles));
                    Console.WriteLine(missingFiles);
                }
            }

        }
    }
}
