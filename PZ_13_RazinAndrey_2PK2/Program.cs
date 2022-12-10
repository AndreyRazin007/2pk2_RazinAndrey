using System;
using System.IO;

namespace PZ_13_AndreyRazin_2PK2
{
    class Program
    {
        private static string[] GetFilesAndSubDirectories(string dir)
        {
            string[] filesAndDirs = Directory.GetFileSystemEntries(dir);
            return filesAndDirs;
        }

        private static void Main()
        {
            string? directories = Console.ReadLine();
            if (Directory.Exists(directories))
            {
                foreach (string fileAndDir in GetFilesAndSubDirectories(directories))
                {
                    Console.WriteLine(fileAndDir);
                }
            }
        }
    }
}