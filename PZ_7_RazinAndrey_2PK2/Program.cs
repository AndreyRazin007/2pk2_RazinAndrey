using System;

namespace PZ_7_AndreyRazin_2PK2
{
    class Program
    {
        private static void Main()
        {
            int[] numbers = new int[20];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = random.Next(0, 100);
                Console.Write($"Элемент массива {numbers[i]} || ");
                bool isDuplicate = false;

                for (int j = 0; j < i; ++j)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                    Console.WriteLine($"Уникальный элемент массива: {numbers[i]}");
            }
        }
    }
}