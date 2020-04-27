using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public static class PlayerManager
    {
        public static void AddPlayers(List<Player> Players, int playerCount)
        {
            var Rnd = new Random();
            for (int n = 0; n < playerCount; n++)
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
            }
        }
        public static void WinnerDetermination(Player whoWin, List<Player> winners)
        {
            Logger.Winner(whoWin);
            if (whoWin != null)
            {
                whoWin.ReturnToBasic();
                winners.Add(whoWin);
            }
        }
        public static Player getRandomPlayer(List<Player> players)
        {
            var Rnd = new Random();
            int i = Rnd.Next(0, players.Count);
            var player = players[i];
            players.RemoveAt(i);
            return player;
        }
    }
}
