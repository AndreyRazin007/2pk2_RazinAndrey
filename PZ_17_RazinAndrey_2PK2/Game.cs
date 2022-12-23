using System;

namespace PZ_17_RazinAndrey_2PK2
{
    class Game
    {
        public static int countEnemy = 10;
        public static int countMedicineKit = 5;
        public static int countBoost = 3;

        public static int countStroke = 0;

        public static int enemyPower = 5;

        public static int playerHP = 30;
        public static int playerPower = 5;

        public static void Move(ref int positionX, ref int positionY)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key != ConsoleKey.W && keyInfo.Key != ConsoleKey.A && keyInfo.Key != ConsoleKey.S && keyInfo.Key != ConsoleKey.D)
            {
                Console.Clear();
                Map.UpdateMap();
            }

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    if (Map.map[positionX - 1, positionY] == Map.enemy) Action.Fight();
                    if (Map.map[positionX - 1, positionY] == Map.medicineKit) Action.Healing();
                    if (Map.map[positionX - 1, positionY] == Map.boost) Action.Buff();
                    Map.map[positionX, positionY] = '.';
                    Map.map[positionX - 1, positionY] = Map.player;
                    --positionX;
                    ++countStroke;
                    Map.UpdateMap();
                    break;
                case ConsoleKey.A:
                    if (Map.map[positionX, positionY - 1] == Map.enemy) Action.Fight();
                    if (Map.map[positionX, positionY - 1] == Map.medicineKit) Action.Healing();
                    if (Map.map[positionX, positionY - 1] == Map.boost) Action.Buff();
                    Map.map[positionX, positionY] = '.';
                    Map.map[positionX, positionY - 1] = Map.player;
                    --positionY;
                    ++countStroke;
                    Map.UpdateMap();
                    break;
                case ConsoleKey.S:
                    if (Map.map[positionX + 1, positionY] == Map.enemy) Action.Fight();
                    if (Map.map[positionX + 1, positionY] == Map.medicineKit) Action.Healing();
                    if (Map.map[positionX + 1, positionY] == Map.boost) Action.Buff();
                    Map.map[positionX, positionY] = '.';
                    Map.map[positionX + 1, positionY] = Map.player;
                    ++positionX;
                    ++countStroke;
                    Map.UpdateMap();
                    break;
                case ConsoleKey.D:
                    if (Map.map[positionX, positionY + 1] == Map.enemy) Action.Fight();
                    if (Map.map[positionX, positionY + 1] == Map.medicineKit) Action.Healing();
                    if (Map.map[positionX, positionY + 1] == Map.boost) Action.Buff();
                    Map.map[positionX, positionY] = '.';
                    Map.map[positionX, positionY + 1] = Map.player;
                    ++positionY;
                    ++countStroke;
                    Map.UpdateMap();
                    break;
            }
        }
    }
}
