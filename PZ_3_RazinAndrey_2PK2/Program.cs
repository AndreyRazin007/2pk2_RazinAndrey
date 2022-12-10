using System;

namespace PZ_3_RazinAndrey_2PK2
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите числа a и h: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            double x, y, z;

            if (h > 3.5)
            {
                x = h * Math.Cos(a + Math.Sqrt(a + h));

                if (x <= 7)
                {
                    y = a * Math.Pow(h, 2) + 4 * Math.Sin(x) + x;
                    z = (a * Math.Pow(h, 3)) / (Math.Pow(x, 2) + Math.Abs(y) + 10);
                    Console.WriteLine($"Значение z = {z}");
                }

                else if (x > 7)
                {
                    y = Math.Exp(a) + Math.Pow(x, 2) - h * x;
                    z = (a * Math.Pow(h, 3)) / (Math.Pow(x, 2) + Math.Abs(y) + 10);
                    Console.WriteLine($"Значение z = {z}");
                }
            }

            else if (h <= 3.5)
            {
                x = a * Math.Sin(h + 1) + 4.5 * a;

                if (x <= 7)
                {
                    y = a * Math.Pow(h, 2) + 4 * Math.Sin(x) + x;
                    z = (a * Math.Pow(h, 3)) / (Math.Pow(x, 2) + Math.Abs(y) + 10);
                    Console.WriteLine($"Значение z = {z}");
                }

                else if (x > 7)
                {
                    y = Math.Exp(a) + Math.Pow(x, 2) - h * x;
                    z = (a * Math.Pow(h, 3)) / (Math.Pow(x, 2) + Math.Abs(y) + 10);
                    Console.WriteLine($"Значение z = {z}");
                }
            }

        }
    }
}