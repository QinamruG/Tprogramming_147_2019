using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public static class Fight
    {
        public static void Attack(Player whoAttacked, Player whoWasAttacked)  // атака
        {
            var rnd = new Random();
            int numberOfAction = rnd.Next(0, whoAttacked.Actions.Count);
            if (whoAttacked.Curses != null)
            {
                if (!whoAttacked.Curses.Any(x => x.Skipping == true) && whoAttacked.Actions[numberOfAction].ActionRange != 0)
                {
                    UseAction();
                }
                for (int i = 0; i < whoAttacked.Curses.Count; i++)
                {
                    whoAttacked.Health -= whoAttacked.Curses[i].CurseDamage;
                    Logger.WriteLog($"{whoAttacked.Name} пролучил {whoAttacked.Curses[i].CurseDamage} ед. урона от проклятия '{whoAttacked.Curses[i].CurseName}!'");
                }
            }
            else
            {
                UseAction();
            }

            void UseAction()
            {
                whoWasAttacked.Health -= whoAttacked.Actions[numberOfAction].ActionDamage; // урон

                if (whoAttacked.Actions[numberOfAction].ActionCurse != null) // добавление проклятия
                {
                    whoWasAttacked.Curses.Add(whoAttacked.Actions[numberOfAction].ActionCurse);
                }
                whoAttacked.Actions[numberOfAction].ActionRange--;

                Logger.WriteLog($"--------{whoAttacked.Name}({whoAttacked.PClass}) применил {whoAttacked.Actions[numberOfAction].ActionName} и нанес {whoAttacked.Actions[numberOfAction].ActionDamage} ед. урона! ------- ");
            }


            //whoWasAttacked.Health -= whoAttacked.actions[numberOfAction].ActionDamage;
            //whoWasAttacked.curses.Add(whoAttacked.actions[numberOfAction].curses);

            // if (whoAttacked.actions[numberOfAction].Curse == AllCurses.Any(x => x.CurseName))
            //{
            //    whoWasAttacked.curses.Add(whoAttacked.actions[numberOfAction].curses);
            //}

            // whoAttacked.actions[Rnd.Next(0,whoAttacked.actions.Count())]

            // whoWasAttacked.curse.Add(whoAttacked.actions[numberOfAction].curse);

            // whoWasAttacked.Health -= whoAttacked.actions[numberOfAction].ActionDamage;

        }
        /*public static void CurseCheck(Player player) // проверка на проклятия
        {
            if (player.curses.Count != 0)
            {

            }
        }*/
        /*public static void GameTurn(Player player1, Player player2)  // игровая очередь
        {
            var Rnd = new Random();
            List<Player> players = new List<Player>{player1, player2}
            List<Player> turn = new List<Player>();
        }*/
    }
}