using System;

namespace PZ_8_AndreyRazin_2PK2
{
    class Program
    {
        private static void Main()
        {
            // Создаем массив
            int[,] matrix = new int[4, 4];
            Random rand = new Random();

            // Выводим элементы массива в консоль
            int i = 0, j = 0;
            int minValue = 1000;
            for (i = 0; i < 4; ++i)
            {
                for (j = 0; j < 4; ++j)
                {
                    matrix[i, j] = rand.Next(0, 100);
                    Console.Write($"matrix[{i}, {j}] = {matrix[i, j]} ");

                    // Минимальный элемент ниже побочной диагонали
                    if (i + j == 4)
                    {
                        if (minValue > matrix[i, j])
                        {
                            minValue = matrix[i, j];
                        }
                    }
                }

                Console.WriteLine();
            }

            // Выводим элементы массива ниже побочной диагонали
            Console.WriteLine(matrix[1, 3]);
            Console.WriteLine(matrix[2, 3]);
            Console.WriteLine(matrix[3, 3]);
            Console.WriteLine(matrix[2, 2]);
            Console.WriteLine(matrix[3, 2]);
            Console.WriteLine(matrix[3, 1]);

            Console.Write($"Минимальный элемент ниже побочной диагонали = {minValue}");
        }
    }
}