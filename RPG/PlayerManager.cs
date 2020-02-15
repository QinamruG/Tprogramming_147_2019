using System;
using System.Collections.Generic;

namespace RPG
{
    public static class PlayerManager
    {
        public static void SelectClass(List<Player> Players, int playerCount)
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
        /*public static void SortOpponents()
        {
        }*/
        public static void WinnerDetermination(Player whoWin, Player whoLose, int winnerHP, List<Player> Players, List<Player> Winners)
        {
            Logger.Winner(whoWin, whoLose);
            whoWin.Debuff = false;
            whoWin.Health = winnerHP;
            Winners.Add(whoWin);
            // Players.Add(whoWin);
        }
    }
}
