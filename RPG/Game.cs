using System;
using System.Collections.Generic;
using System.Linq;
namespace RPG
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Начать турнир?(y/n)");

            var s = Console.ReadLine();

            Game.RightInputCheck(s);

            while (s == "y")
            {
                var tournament = new Tournament();

                tournament.StartTournament();

                Console.WriteLine("Начать еще один турнир?(y/n)");

                s = Console.ReadLine();

                Game.RightInputCheck(s);
            }
        }
        static void RightInputCheck(string s)
        {
            while (s != "y" && s != "n")
            {
                Console.WriteLine("Неизвестная команда,попробуйте еще раз");
                Console.WriteLine("Начать еще один турнир?(y/n)");
                s = Console.ReadLine();
            }
        }
    }
}
