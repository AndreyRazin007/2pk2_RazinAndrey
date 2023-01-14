using System;

namespace PZ_10_AndreyRazin_2PK2
{
    internal class Program
    {
        private static bool IsCorrectEmail(string email)
        {
            bool result = true;
            email = email.Trim();

            string unique = email.Substring(0, email.IndexOf('@'));

            if (unique.Length < 6 && unique.Length > 20) result = false;

            for (int i = 0; i < unique.Length; i++)
            {
                if (!Char.IsLetterOrDigit(unique[i]) &&
                    unique[i] != '.' && unique[i] != '!' &&
                    unique[i] != '-' && unique[i] != '_') result = false;
            }

            return result;
        }

        private static void Main()
        {
            string? email = Console.ReadLine();
            if (IsCorrectEmail(email)) Console.WriteLine("Корректный email");
            else Console.WriteLine("Некорректный email");
        }
    }
}