using System;

namespace PZ_5_AndreyRazin_2PK2
{
    class Program
    {
        private static void Main()
        {
            // Первое задание
            for (int i = 20; i <= 90; i += 5)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();

            // Второе задание
            char simvol = 'Ж';
            for (int i = 1046; i < 1051; ++i)
            {
                Console.WriteLine($"{simvol++}");
            }

            // Третье задание
            for (int i = 0; i < 8; ++i) // Счётчик строк
            {
                Console.WriteLine();
                for (int j = 0; j < 7; ++j) // Счётчик символов
                {
                    Console.Write('#');
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            // Четвёртое задание
            for (int i = 13; i <= 100; ++i)
            {
                if (i % 13 == 0) Console.WriteLine($"{i}");
            }
            Console.WriteLine();

            //Пятое задание
            for (int i = 5, j = 100; ; ++i, --j)
            {
                Console.WriteLine($"{i}, {j}");
                if ((i - j) == 9) break;
            }
        }
    }
}