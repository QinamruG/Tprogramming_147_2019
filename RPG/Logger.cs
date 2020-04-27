using System;
using System.Collections.Generic;

namespace RPG
{
    public static class Logger
    {
        public static void WriteLog(string s)
        {
            Console.WriteLine(s);
        }
        public static void WhichCon(int con)
        {
            Console.WriteLine($"\n ======================= \n   Начинается {con}-й кон!!!\n =======================");
        }
        public static void Winner(Player winner)
        {
            if (winner == null)
                Console.WriteLine("Все погибли");
            else
                Console.WriteLine($"{winner.Name}({winner.PClass}) побеждает своего противника!");

        }
        public static void whoAgainstWhom(List<Player> players)
        {
            string s = $"=!=!=!=!=!= {players[0].Name}({players[0].PClass})";
            for (int i = 1; i < players.Count; i++)
            {
                s += $" sv {players[i].Name}({players[i].PClass})";
            }
            s += " =!=!=!=!=!=";
            Console.WriteLine(s);
        }
    }
}