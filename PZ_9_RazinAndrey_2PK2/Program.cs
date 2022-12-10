using System;
using System.Linq;

namespace PZ_9_AndreyRazin_2PK2
{
    class Program
    {
        private static void Main()
        {
            // Задание 1
            int[][] numbers = new int[5][];

            Random random_1 = new Random();
            Random random_2 = new Random();
            Random random_3 = new Random();
            Random random_4 = new Random();
            Random random_5 = new Random();

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    numbers[i] = new int[] { random_1.Next(1, 100), random_2.Next(1, 100),
                                             random_3.Next(1, 100), random_4.Next(1, 100),
                                             random_5.Next(1, 100) };
                    // Задание 2
                    Console.WriteLine($"numbers[{i}][{j}] = {numbers[i][j]}");
                }
            }

            // Задание 3
            int lastNumber_1 = numbers[0][4];
            int lastNumber_2 = numbers[1][4];
            int lastNumber_3 = numbers[2][4];
            int lastNumber_4 = numbers[3][4];
            int lastNumber_5 = numbers[4][4];
            int[] lastNumbers = { lastNumber_1, lastNumber_2,
                                  lastNumber_3, lastNumber_4,
                                  lastNumber_5 };
            Console.WriteLine($"lastNumbers[{0}] = {lastNumbers[0]}");
            Console.WriteLine($"lastNumbers[{1}] = {lastNumbers[1]}");
            Console.WriteLine($"lastNumbers[{2}] = {lastNumbers[2]}");
            Console.WriteLine($"lastNumbers[{3}] = {lastNumbers[3]}");
            Console.WriteLine($"lastNumbers[{4}] = {lastNumbers[4]}");

            // Задание 4
            int maxNumbers_1 = numbers[0].Max();
            int maxNumbers_2 = numbers[1].Max();
            int maxNumbers_3 = numbers[2].Max();
            int maxNumbers_4 = numbers[3].Max();
            int maxNumbers_5 = numbers[4].Max();
            int[] maxNumbers = { maxNumbers_1, maxNumbers_2,
                                 maxNumbers_3, maxNumbers_4,
                                 maxNumbers_5 };
            Console.WriteLine($"maxNumbers[{0}] = {maxNumbers[0]}");
            Console.WriteLine($"maxNumbers[{1}] = {maxNumbers[1]}");
            Console.WriteLine($"maxNumbers[{2}] = {maxNumbers[2]}");
            Console.WriteLine($"maxNumbers[{3}] = {maxNumbers[3]}");
            Console.WriteLine($"maxNumbers[{4}] = {maxNumbers[4]}");

            // Задание 5
            numbers[0] = new int[5] { maxNumbers_1, random_2.Next(1, 100), random_3.Next(1, 100), random_4.Next(1, 100), random_1.Next(1, 100) };
            numbers[1] = new int[5] { maxNumbers_2, random_2.Next(1, 100), random_3.Next(1, 100), random_4.Next(1, 100), random_1.Next(1, 100) };
            numbers[2] = new int[5] { maxNumbers_3, random_2.Next(1, 100), random_3.Next(1, 100), random_4.Next(1, 100), random_1.Next(1, 100) };
            numbers[3] = new int[5] { maxNumbers_4, random_2.Next(1, 100), random_3.Next(1, 100), random_4.Next(1, 100), random_1.Next(1, 100) };
            numbers[4] = new int[5] { maxNumbers_5, random_2.Next(1, 100), random_3.Next(1, 100), random_4.Next(1, 100), random_1.Next(1, 100) };
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    Console.WriteLine($"updateNumbers[{i}][{j}] = {numbers[i][j]}");
                }
            }

            // Задание 6
            numbers[0].Reverse();
            int[] reverseNumbers_1 = { numbers[0][0], numbers[0][1],
                                     numbers[0][2], numbers[0][3],
                                     numbers[0][4] };
            numbers[1].Reverse();

            int[] reverseNumbers_2 = { numbers[1][0], numbers[1][1],
                                     numbers[1][2], numbers[1][3],
                                     numbers[1][4] };

            numbers[2].Reverse();
            int[] reverseNumbers_3 = { numbers[2][0], numbers[2][1],
                                     numbers[2][2], numbers[2][3],
                                     numbers[2][4] };

            numbers[3].Reverse();
            int[] reverseNumbers_4 = { numbers[3][0], numbers[3][1],
                                     numbers[3][2], numbers[3][3],
                                     numbers[3][4] };

            numbers[4].Reverse();
            int[] reverseNumbers_5 = { numbers[4][0], numbers[4][1],
                                     numbers[4][2], numbers[4][3],
                                     numbers[4][4] };

            // Задание 7
            int mediumOfNumbers_1 = (numbers[0][0] + numbers[0][1]
                                    + numbers[0][2] + numbers[0][3] + numbers[0][4]) / 5;
            int mediumOfNumbers_2 = (numbers[1][0] + numbers[1][1]
                                    + numbers[1][2] + numbers[1][3] + numbers[1][4]) / 5;
            int mediumOfNumbers_3 = (numbers[2][0] + numbers[2][1]
                                    + numbers[2][2] + numbers[2][3] + numbers[2][4]) / 5;
            int mediumOfNumbers_4 = (numbers[3][0] + numbers[3][1]
                                    + numbers[3][2] + numbers[3][3] + numbers[3][4]) / 5;
            int mediumOfNumbers_5 = (numbers[4][0] + numbers[4][1]
                                    + numbers[4][2] + numbers[4][3] + numbers[4][4]) / 5;
        }
    }
}