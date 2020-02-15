using System;
using System.Collections.Generic;
using System.Linq;
namespace RPG
{
    class Game
    {
        static void Main(string[] args)
        {
            var Rnd = new Random();
            Console.WriteLine("Введите четное количество игроков");
            var playerCount = Convert.ToUInt16(Console.ReadLine());
            if (playerCount/2 % 2 == 0 || playerCount == 2)
            {
                List<Player> Players = new List<Player>();
                List<Player> Winners = new List<Player>();

                PlayerManager.SelectClass(Players, playerCount);

                int con = 1;
                int round = 1;

                while (Players.Count + Winners.Count > 1)
                {
                    Logger.WhichCon(con);
                    while (Players.Count > 1)
                    {
                        //Logger.WhichCon(con);
                        Logger.WriteLog($"---------{round}й раунд!------");
                        int i = Rnd.Next(0, Players.Count);
                        var FirstPlayer = Players[i];
                        Players.RemoveAt(i);
                        i = Rnd.Next(0, Players.Count - 1);
                        var SecondPlayer = Players[i];
                        Players.RemoveAt(i);
                        int firstPlHP = FirstPlayer.Health;
                        int secPlHP = SecondPlayer.Health;
                        var whoIsAttack = Rnd.Next(1, 3);
                        while (FirstPlayer.Health > 0 && SecondPlayer.Health > 0)
                        {
                            if (whoIsAttack == 1)
                            {
                                Fight.Attack(FirstPlayer, SecondPlayer);
                                whoIsAttack = 2;
                            }
                            else
                            {
                                Fight.Attack(SecondPlayer, FirstPlayer);
                                whoIsAttack = 1;
                            }
                        }
                        if (FirstPlayer.Health < 1)
                        {
                            PlayerManager.WinnerDetermination(SecondPlayer, FirstPlayer, secPlHP, Players, Winners);
                        }
                        else if (SecondPlayer.Health < 1)
                        {
                            PlayerManager.WinnerDetermination(FirstPlayer, SecondPlayer, firstPlHP, Players, Winners);
                        }
                        else { throw new Exception("У нас сдаваться запрещено!"); }
                        //con++;
                        round++;
                    }
                    Players.AddRange(Winners.ToArray());
                    Winners.Clear();
                    con++;
                    round = 1;
                }
                Logger.WriteLog($"\n========================\n{Players[0].Name}({Players[0].PClass}) выигрывает соревнование!!\n========================");

            }
            else { throw new Exception("Неправильно задано количество игроков"); }
        }
    }
}
