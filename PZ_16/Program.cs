using System;
using System.IO;

namespace PZ_16_RazinAndrey_2PK2
{
    class Program
    {
        private static void Main()
        {
            string path = @"C:\Users\razin.ad1694\source\repos\inFile.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                char[] str = text.ToCharArray();
                int result = 0;
                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i] == '\n') result += 1;
                }
                Console.WriteLine($"Количество строк в файле {path} = {result + 1}");
            }

            string[] line = File.ReadAllLines(@"C:\Users\razin.ad1694\source\repos\inFile.txt");
            for (int i = 0; i < line.Length; ++i)
            {
                int countChar;
                countChar = line[i].Length;
                Console.WriteLine($"Количество символов в строке {line[i]} = {countChar}");
            }
        }
    }
}