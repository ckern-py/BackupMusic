using System;
using System.Collections.Generic;
using System.Linq;

namespace MoveFilesBackup
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> sourceDirectoryFiles = new List<string>();
            List<string> targetDirectoryFiles = new List<string>();

            string sourceDirectory = @"D:\Colin\Backup\Music\Albums";
            string targetDirectory = @"C:\Users\Colin\Music\Albums";

            DirectoryMusic backupMusicFilesOperations = new DirectoryMusic();

            sourceDirectoryFiles = backupMusicFilesOperations.WalkDirectory(sourceDirectory);
            targetDirectoryFiles = backupMusicFilesOperations.WalkDirectory(targetDirectory);

            List<string> notInTargetLocation = sourceDirectoryFiles.Except(targetDirectoryFiles).ToList();

            Console.WriteLine("Creating new directories in target location");

            backupMusicFilesOperations.CreateFolders(notInTargetLocation, targetDirectory);

            Console.WriteLine("\nMoving the files over now");

            backupMusicFilesOperations.CopyFiles(notInTargetLocation, sourceDirectory, targetDirectory);

            Console.WriteLine("\nBoth directories should be the same now");
            Console.ReadLine();
        }
    }
}