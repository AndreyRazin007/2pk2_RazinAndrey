using System;

namespace Lessons
{
    class Program
    {
        private static void Main()
        {
            Shed shed = new(-20, 50);
            shed.PrintInfo();
        }
    }

    class Shed
    {
        public int Width
        {
            get;
            private set;
        }

        public int Height
        {
            get;
            private set;
        }

        public Shed(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void PrintInfo()
        {
            Console.Write($"{Width}, {Height}");
        }
    }
}