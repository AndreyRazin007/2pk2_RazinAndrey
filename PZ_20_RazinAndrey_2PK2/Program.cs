using System;

namespace PZ_20_RazinAndrey_2PK2
{
    internal class Program
    {
        unsafe static void Main()
        {
            int* numbers = stackalloc int[2];
            int* points = numbers;

            int count = 1;
            for (int i = 0; i < 2; ++i, ++points, ++count)
            {
                *points += count;
                Console.WriteLine($"Значение элемента {i} массива numbers = {*points}");
            }

            int* start_1 = &numbers[0], end_1 = start_1 + 1;
            byte* point_1 = (byte*)start_1;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine($"Ячейка памяти: {i} numbers[0] = {*point_1}");
                ++point_1;
            }

            Console.WriteLine();

            int* start_2 = &numbers[1], end_2 = start_2 + 1;
            byte* point_2 = (byte*)start_2;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine($"Ячейка памяти: {i} numbers[1] = {*point_2}");
                ++point_2;
            }
        }
    }
}