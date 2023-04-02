using System;

namespace PZ_27
{
    enum Zodiac : int
    {
        Aries = 1,
        Taurus = 2,
        Gemini = 3,
        Gancer = 4,
        Leo = 5,
        Virgo = 6,
        Libra = 7,
        Scorpio = 8,
        Sagittarius = 9,
        Capricorn = 10,
        Aquarius = 11,
        Pisces = 12,
    }

    struct ZodiacSign
    {
        private string name;
        private Zodiac zodiac;
        private string nameZodiac;
        private readonly int[] birthday;

        public string Name
        {
            get { return name; }
            set
            {
                if (name.Length > 255 || name.Length == 0)
                    Console.WriteLine("Your name is too long or missing");
                else
                    name = value;
            }
        }

        public Zodiac Zodiac
        {
            get { return zodiac; }
            set
            {
                if ((int)zodiac < 1 || (int)zodiac > 12)
                    Console.WriteLine("Incorrect zodiac sign");
                else zodiac = value;
            }
        }

        public string NameZodiac
        {
            get { return nameZodiac; }
            set
            {
                switch (zodiac)
                {
                    case (Zodiac)1: nameZodiac = "Aries"; break;
                    case (Zodiac)2: nameZodiac = "Taurus"; break;
                    case (Zodiac)3: nameZodiac = "Gemini"; break;
                    case (Zodiac)4: nameZodiac = "Gancer"; break;
                    case (Zodiac)5: nameZodiac = "Leo"; break;
                    case (Zodiac)6: nameZodiac = "Virgo"; break;
                    case (Zodiac)7: nameZodiac = "Libra"; break;
                    case (Zodiac)8: nameZodiac = "Scorpio"; break;
                    case (Zodiac)9: nameZodiac = "Sagittarius"; break;
                    case (Zodiac)10: nameZodiac = "Capricorn"; break;
                    case (Zodiac)11: nameZodiac = "Aquarius"; break;
                    case (Zodiac)12: nameZodiac = "Pisces"; break;
                }
            }
        }

        public int[] BirthDay
        {
            get { return birthday; }
            set
            {
                if (birthday[0] > 31 || birthday[0] < 1 ||
                    birthday[1] > 12 || birthday[1] < 1)
                    Console.WriteLine("Incorrect date");
            }
        }

        public void PrintInfo()
        {
            Console.Write($"Your name: {Name}\nYour Zodiac: {NameZodiac}\n" +
                $"Your birthday: {BirthDay[0]}, {BirthDay[1]}, {BirthDay[2]}\n");
        }

        public ZodiacSign(string name, Zodiac zodiac, string nameZodiac, int[] birthday)
        {
            this.name = name;
            this.zodiac = zodiac;
            this.nameZodiac = nameZodiac;
            this.birthday = birthday;
        }
    }
}
