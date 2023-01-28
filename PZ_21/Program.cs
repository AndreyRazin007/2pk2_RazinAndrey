using System;

namespace PZ_21
{
    class Program
    {
        private static void Main()
        {
            Subject subject_1 = new();
            subject_1.PrintInfo();

            Console.Write("\n\n");

            Subject subject_2 = new("Programing");
            subject_2.PrintInfo();

            Console.Write("\n\n");

            Subject subject_3 = new("Base Data", 350); // Я к сожалению забыл, сколько на базы данных часов выделяется, прошу простить)
            subject_3.PrintInfo();

            Console.Write("\n\n");

            Subject subject_4 = new("History", 320, "Credit");
            subject_4.PrintInfo();

            Console.Write("\n\n");

            Subject subject_5 = new("", "");
            subject_5.PrintInfo();
        }
    }
}