using System;
using System.Collections.Generic;
namespace RPG
{
    class Game
    {
        public static List<string> names = new List<string>(){"Arthur", "Hesoyam"};
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Введите четное количество игроков");
            var playerCount = Console.ReadLine();
            if(playerCount % 2 == 0)
            {
                
            }
            else  { throw new Exception("Вы должны ввести четное количество игроков"); }
        }
    }
}
