using System;

namespace PZ_17_RazinAndrey_2PK2
{
    class Program
    {
        private static char[,] map = new char[25, 25];

        const char player = 'P';
        const char enemy = 'E';
        const char medicineKit = 'M';
        const char boost = 'B';

        private static int playerHP = 30;
        private static int playerPower = 5;

        private static int enemyHP = 15;
        private static int enemyPower = 5;

        private static void MapGenerate()
        {
            for (int i = 0; i < map.GetLength(0); ++i)
            {
                for (int j = 0; j < map.GetLength(1); ++j)
                {
                    map[i, j] = '#';
                }
            }

            EnemyGenerate();
            BoostGenerate();
            MedicineKitGenerate();
        }

        private static void EnemyGenerate()
        {
            for (int i = 0; i < 10; ++i)
            {
                Random random = new Random();
                int x = random.Next(5, 25);
                int y = random.Next(5, 25);
                if (map[x, y] == '#' && map[x, y] != boost && map[x, y] != medicineKit) map[x, y] = enemy;
                else --i;
            }
        }

        private static void BoostGenerate()
        {
            for (int i = 0; i < 3; ++i)
            {
                Random random = new Random();
                int x = random.Next(5, 25);
                int y = random.Next(5, 25);
                if (map[x, y] == '#' && map[x, y] != enemy && map[x, y] != medicineKit) map[x, y] = boost;
                else --i;
            }
        }

        private static void MedicineKitGenerate()
        {
            for (int i = 0; i < 5; ++i)
            {
                Random random = new Random();
                int x = random.Next(5, 25);
                int y = random.Next(5, 25);
                if (map[x, y] == '#' && map[x, y] != enemy && map[x, y] != boost) map[x, y] = medicineKit;
                else --i;
            }
        }

        private static void UpdateMap()
        {
            if (playerHP > 0)
            {
                Console.Clear();
                for (int i = 0; i < 25; ++i)
                {
                    for (int j = 0; j < 25; ++j)
                    {
                        if (map[i, j] == player) Console.ForegroundColor = ConsoleColor.Yellow;
                        if (map[i, j] == enemy) Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (map[i, j] == medicineKit) Console.ForegroundColor = ConsoleColor.Green;
                        if (map[i, j] == boost) Console.ForegroundColor = ConsoleColor.DarkBlue;
                        if (map[i, j] == '.') Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{map[i, j]} ");
                    }
                    Console.Write('\n');
                }
            }
        }

        private static void Move()
        {
            int playerPositionX = 12;
            int playerPositionY = 12;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    map[playerPositionX, playerPositionY] = '#';
                    map[playerPositionX - 5, playerPositionY] = player;
                    UpdateMap();
                    break;
            }
        }

        private static void Fight()
        {
            int tempPlayerHP = playerHP;
            int tempEnemyHP = enemyHP;

            while (tempPlayerHP < 0 && tempEnemyHP < 0)
            {
                tempPlayerHP -= enemyPower;
                tempEnemyHP -= playerPower;
            }
        }

        private static void Healing()
        {
            playerHP = 30;
        }

        private static void Boost()
        {
            playerPower *= 2;
        }

        private static void StartGame()
        {
            MapGenerate();
            int x = 12;
            int y = 12;
            map[x, y] = player;

            for (int i = 0; i < 25; ++i)
            {
                for (int j = 0; j < 25; ++j)
                {
                    if (map[i, j] == player) Console.ForegroundColor = ConsoleColor.Yellow;
                    if (map[i, j] == enemy) Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (map[i, j] == medicineKit) Console.ForegroundColor = ConsoleColor.Green;
                    if (map[i, j] == boost) Console.ForegroundColor = ConsoleColor.DarkBlue;
                    if (map[i, j] == '#') Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{map[i, j]} ");
                }
                Console.Write('\n');
            }
            Move();
        }

        private static void Main()
        {
            StartGame();
        }
    }
}