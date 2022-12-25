using System;
using System.Threading;

namespace PZ_17_RazinAndrey_2PK2
{
    class ConsoleGame
    {
        public enum ColorCharacter
        {
            Yellow = ConsoleColor.Yellow,
            DarkRed = ConsoleColor.DarkRed,
            Green = ConsoleColor.Green,
            DarkBlue = ConsoleColor.DarkBlue,
            White = ConsoleColor.White
        }

        public static void EndGame()
        {
            Console.Clear();
            if (Game.playerHP <= 0) Console.WriteLine("Вы не смогли победить всех врагов, возращайтесь снова и покажите свою силу!");
            if (Game.playerHP == 0 && Game.countEnemy == 0) Console.WriteLine("Ценой собственной жизни вы смогли победить всех врагов, ваша жертва не была напрасной!");
            if (Game.countEnemy == 0) Console.WriteLine("Вы достойно сражались и смогли искоренить зло, примите наши поздравления!");
            Thread.Sleep(3000);
            Console.Clear();

            for (int i = 5; i > 0; --i)
            {
                Console.WriteLine($"Игра завершится через: {i}");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public static void StartGame()
        {   
            Map.MapGenerate();

            for (int i = 0; i < 25; ++i)
            {
                for (int j = 0; j < 25; ++j)
                {
                    if (Map.map[i, j] == Map.player) Console.ForegroundColor = (ConsoleColor)ColorCharacter.Yellow;
                    if (Map.map[i, j] == Map.enemy) Console.ForegroundColor = (ConsoleColor)ColorCharacter.DarkRed;
                    if (Map.map[i, j] == Map.medicineKit) Console.ForegroundColor = (ConsoleColor)ColorCharacter.Green;
                    if (Map.map[i, j] == Map.boost) Console.ForegroundColor = (ConsoleColor)ColorCharacter.DarkBlue;
                    if (Map.map[i, j] == '.') Console.ForegroundColor = (ConsoleColor)ColorCharacter.White;
                    Console.Write($"{Map.map[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.WriteLine();

            Console.WriteLine($"Здоровье игрока: {Game.playerHP}");
            Console.WriteLine($"Количество аптечек: {Game.countMedicineKit}");
            Console.WriteLine($"Количество бустов: {Game.countBoost}");
            Console.WriteLine($"Оставшиеся враги: {Game.countEnemy}");
            Console.WriteLine($"Сила игрока: {Game.playerPower}");
            Console.WriteLine($"Количество ходов: {Game.countStroke}");
        }

        public static void Main()
        {
            StartGame();

            int positionX = 12;
            int positionY = 12;

            while (Game.playerHP > 0 && Game.countEnemy > 0)
            {
                Game.Move(ref positionX, ref positionY);
            }

            EndGame();
        }
    }
}