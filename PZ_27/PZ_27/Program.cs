using System;

namespace PZ_27
{
    class Program
    {
        private static void Main()
        {
            ZodiacSign zodiacSign = new("Andrey Razin", Zodiac.Scorpio, "Scorpio", new[] { 30, 10, 2005 });
            zodiacSign.PrintInfo();

            Console.Write("\n");

            ZodiacSign[] book = new ZodiacSign[8];
        }
    }
}
