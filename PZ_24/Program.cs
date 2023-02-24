using System;

namespace PZ_24
{
    class Program
    {
        private static void Main()
        {
            Atom atom = new(5);
            atom.PrintInfo();

            Console.WriteLine("\n");

            RadioactiveAtom radioactiveAtom = new(0);
            radioactiveAtom.PrintInfo();
        }
    }
}
