using System;
using System.Collections.Generic;

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
        /*public static void ChooseOpponents(List<Player> Players, Player FirstPlayer, Player SecondPlayer, int firstPlHP, int secPlHP)
        {
            var Rnd = new Random();
            int i = Rnd.Next(0, Players.Count);
            FirstPlayer = Players[i];
            Players.RemoveAt(i);
            i = Rnd.Next(0, Players.Count - 1);
            SecondPlayer = Players[i];
            Players.RemoveAt(i);
            firstPlHP = FirstPlayer.Health;
            secPlHP = SecondPlayer.Health;

        }*/

        public static void WinnerDetermination(Player whoWin, Player whoLose, int winnerHP, List<Player> Winners)
        {
            Logger.Winner(whoWin, whoLose);
            whoWin.Curses.Clear();
            whoWin.Actions.AddRange(whoWin.EndedActions);
            whoWin.EndedActions.Clear();
            for (int i = 0; i < whoWin.Actions.Count; i++)
            {
                whoWin.Actions[i].ActionRange = whoWin.Actions[i].BasicRange;
                if (whoWin.Actions[i].ActionCurse != null)
                {
                    whoWin.Actions[i].ActionCurse.CurseDuration = whoWin.Actions[i].ActionCurse.BasicDuration;
                }
            }
            whoWin.Health = winnerHP;
            Winners.Add(whoWin);
        }
    }
}
