using System;
using System.Collections.Generic;
using System.Linq;
namespace RPG
{
    public class Tournament
    {
        public void StartTournament()
        {
            var PowersOfTwo = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
            var Rnd = new Random();
            Console.WriteLine("Введите корректное число игроков");
            var playerCount = Convert.ToUInt16(Console.ReadLine());
            if (PowersOfTwo.Any(x => x.Equals(playerCount)))
            {
                List<Player> players = new List<Player>();
                List<Player> winners = new List<Player>();

                PlayerManager.AddPlayers(players, playerCount);

                int con = 1;
                int round = 1;
                // Разбить код - Turnament, Round
                while (players.Count + winners.Count > 1)
                {
                    Logger.WhichCon(con);
                    while (players.Count > 1)
                    {
                        var playersForRound = new List<Player>();
                        Logger.WriteLog($"---------{round}-й раунд!------");
                        int i = Rnd.Next(0, players.Count); // getRandomPlayer method
                        playersForRound.Add(players[i]);
                        players.RemoveAt(i);
                        i = Rnd.Next(0, players.Count - 1);
                        playersForRound.Add(players[i]);
                        players.RemoveAt(i);

                        int firstPlHP = FirstPlayer.Health;
                        int secPlHP = SecondPlayer.Health;

                        var whoIsAttack = Rnd.Next(1, 3);
                        // var FirstPlayer = playersForRound. - забираем из списка - и удаляем в списке
                        // var SecondPlayer = players[i]; - берем оставшегося

                        while (FirstPlayer.Health > 0 && SecondPlayer.Health > 0)
                        {
                                Fight.Attack(FirstPlayer, SecondPlayer); //Проверять - останется ли жив 2
                                Fight.Attack(SecondPlayer, FirstPlayer);
                        }
                        if (FirstPlayer.Health < 1)
                        {
                            PlayerManager.WinnerDetermination(SecondPlayer, FirstPlayer, secPlHP, winners);
                        }
                        else if (SecondPlayer.Health < 1)
                        {
                            PlayerManager.WinnerDetermination(FirstPlayer, SecondPlayer, firstPlHP, winners);
                        }
                        else { throw new Exception("У нас сдаваться запрещено!"); }

                        round++;
                    }
                    players.AddRange(winners.ToArray());
                    winners.Clear();
                    con++;
                    round = 1;
                }
                Logger.WriteLog($"\n========================\n{players[0].Name}({players[0].PClass}) выигрывает соревнование!!\n========================");
            }
            else { throw new Exception("Неправильно задано число игроков"); }
        }
    }

}