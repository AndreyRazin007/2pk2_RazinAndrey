namespace PZ_17_RazinAndrey_2PK2
{
    class Action
    {
        public static void Fight()
        {
            int enemyHP = 15;
            while (Game.playerHP > 0 && enemyHP > 0)
            {
                Game.playerHP -= Game.enemyPower;
                enemyHP -= Game.playerPower;
            }
            --Game.countEnemy;
        }

        public static void Healing()
        {
            if (Game.playerHP < 30) Game.playerHP = 30;
            --Game.countMedicineKit;
        }

        public static void Buff()
        {
            Game.playerHP += 15;
            if (Game.playerPower < 15) Game.playerPower += 5;
            if (Game.playerPower == 15) Game.playerPower = 5;
            --Game.countBoost;
        }
    }
}
