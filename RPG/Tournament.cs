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
            Logger.WriteLog("Введите корректное число игроков");
            var playerCount = Convert.ToUInt16(Console.ReadLine());
            while (!PowersOfTwo.Any(x => x.Equals(playerCount)))
            {
                Logger.WriteLog("Попробуйте снова");
                playerCount = Convert.ToUInt16(Console.ReadLine());
            }
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
                    // можно в метод Round передавать список игроков раунда, где они между собой будут сражаться
                    Logger.WhichCon(con);             // лучше логги делать отдельными методами
                    while (players.Count > 1)
                    {
                        Logger.WriteLog($"---------{round}-й раунд!---------"); // или чисто так писать?

                        int roundPlayersCount = 2;
                        var playersForRound = new List<Player>();
                        while (roundPlayersCount != 0)
                        {
                            playersForRound.Add(PlayerManager.getRandomPlayer(players));
                            roundPlayersCount--;
                        }

                        /*var FirstPlayer = PlayerManager.getRandomPlayer(players);
                        var SecondPlayer = PlayerManager.getRandomPlayer(players);

                        //var whoIsAttack = Rnd.Next(0, playersForRound.Count);

                        while (FirstPlayer.Health > 0 && SecondPlayer.Health > 0)
                        {
                            Fight.Attack(FirstPlayer, SecondPlayer); // Проверять - останется ли жив 2
                            Fight.Attack(SecondPlayer, FirstPlayer);
                        }
                        if (FirstPlayer.Health < 1)
                        {
                            PlayerManager.WinnerDetermination(SecondPlayer, winners);
                        }
                        else if (SecondPlayer.Health < 1)
                        {
                            PlayerManager.WinnerDetermination(FirstPlayer, winners);
                        }
                        else
                        {
                            throw new Exception("У нас сдаваться запрещено!");
                        }*/

                        PlayerManager.WinnerDetermination(Round(playersForRound), winners);

                        round++;
                    }
                    players.AddRange(winners.ToArray());
                    winners.Clear();
                    con++;
                    round = 1;
                }
                if (players.Count != 0)
                    Logger.WriteLog($"\n========================\n{players[0].Name}({players[0].PClass}) выигрывает соревнование!!\n========================");
                else
                    Logger.WriteLog("======================== К сожалению, все участники турнира погибли в бою! Турнир удался на славу! ======================== ");
            }
            else { throw new Exception("Неправильно задано число игроков"); }
        }
        public Player Round(List<Player> players)
        {
            Logger.whoAgainstWhom(players);
            while (players.FindAll(x => x.Health > 0).Count > 1)
            {
                foreach (var player in players)
                {
                    if (player.Health > 0)
                        Fight.Attack(player, players.First(x => x != player));
                }
            }
            return players.FirstOrDefault(x => x.Health > 0);
        }
    }
}

