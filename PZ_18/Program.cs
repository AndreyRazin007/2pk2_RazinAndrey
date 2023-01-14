namespace PZ_18_RazinAndrey_2PK2
{
    class Program
    {
        enum Marks
        {
            TooBad = 1,
            Bad = 2,
            Satisfactory = 3,
            Good = 4,
            VeryGood = 5
        }

        enum Seasons
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Fall = 4
        }

        private static void Main()
        {
            Console.Write($"Введите вашу отметку: ");
            int rating = Convert.ToInt32(Console.ReadLine());
            WriteRating(rating);

            Console.Write($"Введите время года: ");
            string season = Console.ReadLine();
            if (season.Length > 0)
            {
                Console.WriteLine("Государственные праздники в это время года: ");
                WriteHolidaysSeason(season);
            }
        }

        private static void WriteRating(int rating)
        {
            switch (rating)
            {
                case 1: Console.WriteLine($"Характеристика отметки {(int)Marks.TooBad}: очень плохо"); break;
                case 2: Console.WriteLine($"Характеристика отметки {(int)Marks.Bad}: плохо"); break;
                case 3: Console.WriteLine($"Характеристика отметки {(int)Marks.Satisfactory}: удовлетворительно"); break;
                case 4: Console.WriteLine($"Характеристика отметки {(int)Marks.Good}: хорошо"); break;
                case 5: Console.WriteLine($"Характеристика отметки {(int)Marks.VeryGood}: отлично"); break;
                default: Console.WriteLine($"Вы ввели некорреетную отметку"); break;
            }
        }

        private static void WriteHolidaysSeason(string season)
        {
            switch (season)
            {
                case "winter":
                    Console.WriteLine($"01.01 - Новый год");
                    Console.WriteLine($"07.01 - Рождество Христово");
                    Console.Write($"23.02 - День защитника Отечества");
                    break;
                case "spring":
                    Console.WriteLine($"08.03 - Международный женский день");
                    Console.WriteLine($"01.05 - Праздник весны и труда");
                    Console.Write($"09.05 - День Победы");
                    break;
                case "summer":
                    Console.Write($"12.06 - День России");
                    break;
                case "fall":
                    Console.Write($"04.11 - День народного единства");
                    break;
                default: Console.Write($"Вы ввели некорректное время года!"); break;
            }
        }
    }
}