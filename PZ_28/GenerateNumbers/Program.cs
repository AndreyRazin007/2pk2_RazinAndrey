using System;

namespace PZ_28
{
    class Program
    {
        private static void Message(string message) => Console.Write(message);

        private static void Main()
        {
            Wait wait_200 = new(200);
            Counter counter_1 = new();
            counter_1.GenerateNumber(wait_200.Number);
            wait_200.MyEvent += Message;
            wait_200.Message(counter_1.Number);

            Console.WriteLine('\n');

            Wait wait_800 = new(800);
            Counter counter_2 = new();
            counter_2.GenerateNumber(wait_800.Number);
            wait_800.MyEvent += Message;
            wait_800.Message(counter_2.Number);
        }
    }
}