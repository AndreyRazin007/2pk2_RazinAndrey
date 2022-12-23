using System;

namespace PZ_17_RazinAndrey_2PK2
{
    class Map
    {
        public static char[,] map = new char[25, 25];

        public const char player = 'P';
        public const char enemy = 'E';
        public const char medicineKit = 'M';
        public const char boost = 'B';

        public static void MapGenerate()
        {
            for (int i = 0; i < map.GetLength(0); ++i)
            {
                for (int j = 0; j < map.GetLength(1); ++j)
                {
                    map[i, j] = '.';
                }
            }

            int x = 12;
            int y = 12;
            map[x, y] = player;

            EnemyGenerate();
            BoostGenerate();
            MedicineKitGenerate();
        }

        public static void EnemyGenerate()
        {
            for (int i = 0; i < 10; ++i)
            {
                Random random = new Random();
                int x = random.Next(5, 25);
                int y = random.Next(5, 25);
                if (map[x, y] == '.' && map[x, y] != boost && map[x, y] != medicineKit) map[x, y] = enemy;
                else --i;
            }
        }

        public static void BoostGenerate()
        {
            for (int i = 0; i < 3; ++i)
            {
                Random random = new Random();
                int x = random.Next(5, 25);
                int y = random.Next(5, 25);
                if (map[x, y] == '.' && map[x, y] != enemy && map[x, y] != medicineKit) map[x, y] = boost;
                else --i;
            }
        }

        public static void MedicineKitGenerate()
        {
            for (int i = 0; i < 5; ++i)
            {
                Random random = new Random();
                int x = random.Next(5, 25);
                int y = random.Next(5, 25);
                if (map[x, y] == '.' && map[x, y] != enemy && map[x, y] != boost) map[x, y] = medicineKit;
                else --i;
            }
        }

        public static void UpdateMap()
        {
            Console.Clear();

            for (int i = 0; i < 25; ++i)
            {
                for (int j = 0; j < 25; ++j)
                {
                    if (Map.map[i, j] == Map.player) Console.ForegroundColor = ConsoleColor.Yellow;
                    if (Map.map[i, j] == Map.enemy) Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (Map.map[i, j] == Map.medicineKit) Console.ForegroundColor = ConsoleColor.Green;
                    if (Map.map[i, j] == Map.boost) Console.ForegroundColor = ConsoleColor.DarkBlue;
                    if (Map.map[i, j] == '.') Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{Map.map[i, j]} ");
                }
                Console.Write('\n');
            }

            Console.WriteLine();

            Console.WriteLine($"Здоровье игрока: {Game.playerHP}");
            Console.WriteLine($"Количество аптечек: {Game.countMedicineKit}");
            Console.WriteLine($"Количество бустов: {Game.countBoost}");
            Console.WriteLine($"Оставшиеся враги: {Game.countEnemy}");
            Console.WriteLine($"Сила игрока: {Game.playerPower}");
            Console.WriteLine($"Количество ходов: {Game.countStroke}");
        }
    }
}