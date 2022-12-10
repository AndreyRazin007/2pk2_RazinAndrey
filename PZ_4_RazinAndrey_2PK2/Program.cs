using System;

namespace PZ_4_AndreyRazin_2PK2
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Какая скорость ветра?");
            uint windSpeed = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Скорость ветра {windSpeed} м/с");

            switch (windSpeed > 0 && windSpeed < 5)
            {
                case true: Console.WriteLine("Ветер слабый"); break;
            }

            switch (windSpeed > 4 && windSpeed < 11)
            {
                case true: Console.WriteLine("Ветер умеренный"); break;
            }

            switch (windSpeed > 10 && windSpeed < 19)
            {
                case true: Console.WriteLine("Ветер сильный"); break;
            }

            switch (windSpeed > 19)
            {
                case true: Console.WriteLine("Ураган"); break;
            }
        }
    }
}