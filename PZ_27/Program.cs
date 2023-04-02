using System;

namespace PZ_27
{
    class Program
    {
        private static void Main()
        {
            ZodiacSign[] book = new ZodiacSign[8];
            book[0] = new("Иванов Даниил", Zodiac.Aries, "Aries", new[] { 23, 03, 2004 });
            book[1] = new("Смирнов Никита", Zodiac.Gancer, "Gancer", new[] { 30, 06, 2000 });
            book[2] = new("Кузнецов Дамир", Zodiac.Libra, "Libra", new[] { 10, 10, 2002 });
            book[3] = new("Попов Родион", Zodiac.Scorpio, "Scorpio", new[] { 25, 10, 2003 });
            book[4] = new("Васильев Стас", Zodiac.Virgo, "Virgo", new[] { 24, 08, 2006 });
            book[5] = new("Петров Степан", Zodiac.Pisces, "Pisces", new[] { 21, 02, 2001 });
            book[6] = new("Соколов Михаил", Zodiac.Leo, "Leo", new[] { 28, 07, 2005 });
            book[7] = new("Михайлов Искандер", Zodiac.Aquarius, "Aquarius", new[] { 29, 01, 2010 });

            ZodiacSign temp;
            for (int i = 0; i < book.Length - 1; ++i)
            {
                for (int j = 0; j < book.Length - 1; ++j)
                {
                    if ((int)book[j].Zodiac > (int)book[j + 1].Zodiac)
                    {
                        temp = book[j];
                        book[j] = book[j + 1];
                        book[j + 1] = temp;
                    }
                }
            }

            Console.Write("Input month: ");
            string month = Console.ReadLine();

            int number = 0;
            for (int i = 0; i < book.Length; ++i)
            {

                if (Convert.ToInt32(month) == book[i].BirthDay[1])
                {
                    book[i].PrintInfo();
                    Console.WriteLine();
                    ++number;
                }

            }

            if (number == 0)
                Console.Write("There are no people born in this month");
        }
    }
}
