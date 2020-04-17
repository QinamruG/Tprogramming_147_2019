using System;
using System.Collections.Generic;
using System.Linq;
namespace RPG
{
    public class Game
    {
        int[] PowersOfTwo = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
        public static void Main(string[] args)
        {
            Console.WriteLine("Начать турнир?(y/n)");
            var s = Console.ReadLine();
            while (s != "y" && s != "n")
            {
                Console.WriteLine("Неизвестная команда,попробуйте еще раз");
                Console.WriteLine("Начать турнир?(y/n)");
                s = Console.ReadLine();
            }
            while (s == "y")
            {
                var tournament = new Tournament();
                tournament.StartTournament();

                Console.WriteLine("Начать еще один турнир?(y/n)");
                s = Console.ReadLine();
                while (s != "y" && s != "n")
                {
                    Console.WriteLine("Неизвестная команда,попробуйте еще раз");
                    Console.WriteLine("Начать еще один турнир?(y/n)");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
