using System;

namespace PZ_24
{
    enum Valences
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        V = 5,
    }

    class Atom : ICloneable
    {
        private static int valence_1 = 0;
        private static int valence_2 = 0;
        private static int countFreeElectrons = 0;
        private static Valences valences;

        public int CountFreeElectrons
        {
            get { return countFreeElectrons; }
            set { countFreeElectrons = value; }
        }

        public static Valences Valences
        {
            get { return valences; }
            set { valences = value; }
        }

        public virtual void PrintInfo()
        {
            Console.Write($"Количество элементов с первой валентностью: {valence_1}\n" +
                          $"Количество элементов со второй валентностью: {valence_2}\n" +
                          $"Количество свободных электронов: {countFreeElectrons}\n");
            Console.Write($"Valences: {Valences}");
        }

        public Atom(int countElectrons)
        {
            countFreeElectrons = countElectrons;
            if (countFreeElectrons == 1) ++valence_1;
            else if (countFreeElectrons == 2) ++valence_2;
            valences = (Valences)countFreeElectrons;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
