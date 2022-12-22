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

        private static uint countEnemy = 10;
        private static uint countMedicineKit = 5;
        private static uint countBoost = 3;

        private static uint countStroke = 0;

        private static uint enemyPower = 5;

        private static uint playerHP = 30;
        private static int playerPower = 5;

        enum ColorCharacter
        {
            Yellow = ConsoleColor.Yellow,
            DarkRed = ConsoleColor.DarkRed,
            Green = ConsoleColor.Green,
            DarkBlue = ConsoleColor.DarkBlue,
            White = ConsoleColor.White
        }

        private static void MapGenerate()
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

        private static void EnemyGenerate()
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

        private static void BoostGenerate()
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

        private static void MedicineKitGenerate()
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

        private static void UpdateMap()
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

            Console.WriteLine();

            Console.WriteLine($"Здоровье игрока: {playerHP}");
            Console.WriteLine($"Количество аптечек: {countMedicineKit}");
            Console.WriteLine($"Количество бустов: {countBoost}");
            Console.WriteLine($"Оставшиеся враги: {countEnemy}");
            Console.WriteLine($"Сила игрока: {playerPower}");
            Console.WriteLine($"Количество ходов: {countStroke}");
        }

        private static void Move(ref int positionX, ref int positionY)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    if (map[positionX - 1, positionY] == enemy) Fight();
                    if (map[positionX - 1, positionY] == medicineKit) Healing();
                    if (map[positionX - 1, positionY] == boost) Buff();
                    map[positionX, positionY] = '.';
                    map[positionX - 1, positionY] = player;
                    --positionX;
                    ++countStroke;
                    UpdateMap();
                    break;
                case ConsoleKey.A:
                    if (map[positionX, positionY - 1] == enemy) Fight();
                    if (map[positionX, positionY - 1] == medicineKit) Healing();
                    if (map[positionX, positionY - 1] == boost) Buff();
                    map[positionX, positionY] = '.';
                    map[positionX, positionY - 1] = player;
                    --positionY;
                    ++countStroke;
                    UpdateMap();
                    break;
                case ConsoleKey.S:
                    if (map[positionX + 1, positionY] == enemy) Fight();
                    if (map[positionX + 1, positionY] == medicineKit) Healing();
                    if (map[positionX + 1, positionY] == boost) Buff();
                    map[positionX, positionY] = '.';
                    map[positionX + 1, positionY] = player;
                    ++positionX;
                    ++countStroke;
                    UpdateMap();
                    break;
                case ConsoleKey.D:
                    if (map[positionX, positionY + 1] == enemy) Fight();
                    if (map[positionX, positionY + 1] == medicineKit) Healing();
                    if (map[positionX, positionY + 1] == boost) Buff();
                    map[positionX, positionY] = '.';
                    map[positionX, positionY + 1] = player;
                    ++positionY;
                    ++countStroke;
                    UpdateMap();
                    break;
            }
        }

        private static void Fight()
        {
            int enemyHP = 15;
            while (playerHP > 0 && enemyHP > 0)
            {
                playerHP -= enemyPower;
                enemyHP -= playerPower;
            }
            --countEnemy;
        }

        private static void Healing()
        {
            if (playerHP < 30) playerHP = 30;
            --countMedicineKit;
        }

        private static void Buff()
        {
            playerHP += 15;
            playerPower += 5;
        }

        private static void EndGame()
        {
            if (playerHP <= 0)
            {
                Console.Clear();
                Console.WriteLine("Вы не смогли победить всех врагов, возращайтесь с новыми силами и покажите свою силу!");
                Console.ReadKey();
                Console.Clear();
            }

            if (playerHP == 0 && countEnemy == 0)
            {
                Console.Clear();
                Console.WriteLine("Ценой собственной жизни вы смогли победить всех врагов, ваша жертва не была напрасной!");
                Console.ReadKey();
                Console.Clear();
            }

            if (countEnemy == 0)
            {
                Console.Clear();
                Console.WriteLine("Вы достойно сражались и смогли искоренить зло, примите наши поздравления!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void StartGame()
        {   
            MapGenerate();

            for (int i = 0; i < 25; ++i)
            {
                for (int j = 0; j < 25; ++j)
                {
                    if (map[i, j] == player) Console.ForegroundColor = (ConsoleColor)ColorCharacter.Yellow;
                    if (map[i, j] == enemy) Console.ForegroundColor = (ConsoleColor)ColorCharacter.DarkRed;
                    if (map[i, j] == medicineKit) Console.ForegroundColor = (ConsoleColor)ColorCharacter.Green;
                    if (map[i, j] == boost) Console.ForegroundColor = (ConsoleColor)ColorCharacter.DarkBlue;
                    if (map[i, j] == '.') Console.ForegroundColor = (ConsoleColor)ColorCharacter.White;
                    Console.Write($"{map[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.WriteLine();

            Console.WriteLine($"Здоровье игрока: {playerHP}");
            Console.WriteLine($"Количество аптечек: {countMedicineKit}");
            Console.WriteLine($"Количество бустов: {countBoost}");
            Console.WriteLine($"Оставшиеся враги: {countEnemy}");
            Console.WriteLine($"Сила игрока: {playerPower}");
            Console.WriteLine($"Количество ходов: {countStroke}");
        }

        private static void Main()
        {
            StartGame();

            int positionX = 12;
            int positionY = 12;

            while (playerHP > 0 && countEnemy > 0)
            {
                Move(ref positionX, ref positionY);
            }

            EndGame();
        }
    }
}