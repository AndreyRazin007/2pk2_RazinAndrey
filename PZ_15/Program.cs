using System;
using System.IO;

namespace PZ_15_RazinAndrey_2PK2
{
    class Program
    {
        private static void GetNumber(string line)
        {
            char[] str = line.ToCharArray();
            string result = "";
            int countNumber = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    result += Char.ToString(str[i]);
                    if (!Char.IsDigit(str[i + 1])) countNumber += 1;
                }
            }
        }

        private static void Main()
        {
            string fileName = @"C:\Users\razin.ad1694\source\repos\inFile.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                string line = "";
                while (line != "stop")
                {
                    line = Console.ReadLine();
                    writer.WriteLine(line);
                }
            }
            using (StreamReader reader = new StreamReader(fileName))
            {
                Console.WriteLine($"Содержимое файла:");
                Console.WriteLine(reader.ReadToEnd());
            }

            GetNumber("Andrey222Razin777");
        }
    }
}