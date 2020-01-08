using System;
using System.Collections.Generic;
namespace RPG
{
    class Game
    {
        static void Main(string[] args)
        {
            var Rnd = new Random();
            Console.WriteLine("Введите четное количество игроков");
            var playerCount = Convert.ToUInt16(Console.ReadLine());
            if (playerCount % 2 == 0)
            {
                Logger LogText = new Logger();
                List<Player> Players = new List<Player>();
                List<Player> Winners = new List<Player>();
                int n = 0;
                int con = 1;
                //int playerClass = Rnd.Next(1, 3);
                //while (players.Count + winners.Count > 1)
                //{
                while (playerCount > n)
                {
                    int playerClass = Rnd.Next(1, 4);
                    switch (playerClass)
                    {
                        case 1:
                            Players.Add(new Wizard());
                            break;
                        case 2:
                            Players.Add(new Knight());
                            break;
                        default:
                            Players.Add(new Archer());
                            break;
                    }
                    n++;
                }
                //while (players.Count + winners.Count > 1)
                //{
                while (Players.Count > 1)
                {
                    LogText.WhichCon(con);
                    int i = Rnd.Next(0, Players.Count);
                    var FirstPlayer = Players[i];
                    Players.RemoveAt(i);
                    i = Rnd.Next(0, Players.Count - 1);
                    var SecondPlayer = Players[i];
                    Players.RemoveAt(i);
                    int firstPlHP = FirstPlayer.Health;
                    int secPlHP = SecondPlayer.Health;
                    var whoIsAttack = Rnd.Next(1,3);
                    var attackOrUseSkill = Rnd.Next(1,2);
                    while(FirstPlayer.Health > 0 && SecondPlayer.Health > 0 )
                    {
                        if(whoIsAttack == 1)
                        {
                           switch(attackOrUseSkill)
                           {
                               case 1:
                               FirstPlayer.Attack(SecondPlayer);
                               whoIsAttack = 2;
                               break;
                               case 2:
                               FirstPlayer.Skill(/*SecondPlayer*/);
                               whoIsAttack = 2;
                               break;
                           }
                        }
                        else
                        {
                           switch(attackOrUseSkill)
                           {
                               case 1:
                               SecondPlayer.Attack(FirstPlayer);
                               whoIsAttack = 1;
                               break;
                               case 2:
                               SecondPlayer.Skill(/*FirstPlayer*/);
                               whoIsAttack = 1;
                               break;
                           }
                        }
                    }
                    if(FirstPlayer.Health < 1)
                    {
                        LogText.Winner(SecondPlayer, FirstPlayer);
                        SecondPlayer.Health = secPlHP;
                        Players.Add(SecondPlayer);
                    }
                    else if (SecondPlayer.Health < 1)
                    {
                        LogText.Winner(FirstPlayer, SecondPlayer);
                        FirstPlayer.Health = secPlHP;
                        Players.Add(FirstPlayer);
                    }
                    else{ throw new Exception("Хм,что-то не так...У нас сдаваться запрещено!");}
                    con++;
                }
               LogText.WriteLog($"{Players[0].Name}({Players[0].PClass}) выигрывает соревнование!!");

            }
            else { throw new Exception("Вы должны ввести четное количество игроков"); }
        }
    }
}
