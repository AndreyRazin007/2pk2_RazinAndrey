using System;

namespace PZ_6_AndreyRazin_2PK2
{
    class Program
    {
        private static void Main()
        {
            // Задание первое
            uint i = 1; // Счетчик цикла
            uint number = 7; // Фиксированный множитель
            uint result = 1; // Результат
            while (i != 11)
            {
                result = number * i;
                Console.WriteLine($"Произведение {number} на {i} = {result}");
                ++i;
            }
            Console.WriteLine();

            // Задание второе
            uint n = Convert.ToUInt32(Console.ReadLine()); // Количество цифр для вычисления суммы
            uint j = 0; // Счетчик цикла
            uint result_2 = 1; // Результат
            while (j <= n)
            {
                result_2 += j;
                ++j;
            }
            System.Console.WriteLine($"{result_2}");
        }
    }
}