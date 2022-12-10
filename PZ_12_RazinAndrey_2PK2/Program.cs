using System;

namespace PZ_12_AndreyRazin_2PK2
{
    class Program
    {
        private static void Quarter(int x, int y)
        {
            if (x > 0 && y > 0) Console.WriteLine("1 четверть");
            if (x < 0 && y > 0) Console.WriteLine("2 четверть");
            if (x < 0 && y < 0) Console.WriteLine("3 четверть");
            if (x > 0 && y < 0) Console.WriteLine("4 четверть");
        }

        private static void Main()
        {
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine("Введите координаты точек: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Quarter(x, y);
            }
        }
    }
}