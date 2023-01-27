using System;

namespace Practica
{
    class Program
    {
        private static void Main()
        {
            string str = Console.ReadLine();

            try
            {
                for (int i = 0; i < str.Length + 1; ++i)
                {
                    if (str[i] >= 65 && str[i] <= 90)
                        Console.Write($"{Char.ToLower(str[i])}");
                    else if (str[i] >= 97 && str[i] <= 122)
                        Console.Write($"{Char.ToUpper(str[i])}");
                    else Console.Write($"{str[i]}");
                }
            }
            catch
            {
                Console.WriteLine($"\nВозникло исключение!");
            }
        }
    }
}