using System;

namespace RPG
{
    class Logger
    {
        public void WriteLog(string s)
        {
            Console.WriteLine(s);
        }
        public void WriteLog(Player a, Player b)
        {
            Console.WriteLine($"{a}({a.PClass}) vs {b}({b.PClass})");
        }
        public void WriteLog(Player a, Player b, int damage)
        {
            Console.WriteLine($"{a} наносит {b} {damage} ед. урона");
        }
    }
}