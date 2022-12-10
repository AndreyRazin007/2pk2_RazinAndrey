using System;

namespace PZ_14_AndreyRazin_2PK2
{
    class Program
    {
        private static int ArithmeticProgression(int n)
        {
            if (n == 1) return 50;
            return ArithmeticProgression(n - 1) + 9;
        }

        private static double GeometricProgression(int n)
        {
            if (n == 1) return 8;
            return GeometricProgression(n - 1) * 4;
        }

        private static int PrintAtoB(int A, int B)
        {
            if (A > B) return A;
            Console.WriteLine($"Значение A в методе PrintAtoB = {A}");
            if (A == B) Console.Write('\n');
            return PrintAtoB(A + 1, B);
        }

        private static int PrintBtoA(int A, int B)
        {
            if (A < B) return A;
            Console.WriteLine($"Значение A в методе PrintBtoA = {A}");
            return PrintBtoA(A - 1, B);
        }

        private static void Main()
        {
            // Вычисление n члена арифметической прогрессии
            Console.WriteLine("5 член данной арифметической прогрессии " + ArithmeticProgression(5));

            // Вычисление n члена геометрической прогрессии
            Console.WriteLine("5 член данной геометрической прогрессии " + GeometricProgression(5));

            // Вывод всех чисел от A до B
            PrintAtoB(20, 40);

            // Вывод всех чисел от B до A
            PrintBtoA(40, 20);
        }
    }
}