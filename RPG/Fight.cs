using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public static class Fight
    {
        public static void Attack(Player whoAttacked, Player whoWasAttacked)  // атака
        {
            // 1 - Мы запрашиваем у Игрока - дай мне атаку
            // Передаем атаку атакуемому - просим сказать сколько он получил урона / осталось жизни
            var attackAction = whoAttacked.GetAction();            
            if (attackAction){
                whoWasAttacked.GetDamage(attackAction);

            } else {
                // Лог про пропуск хода
            }
            // Вот тут заканчивается этот метод




            var rnd = new Random();
            //var availableActions = whoAttacked.Actions.FindAll(x => x.ActionRange != 0);
            //var availableActions = whoAttacked.ReturnAvailableActions();
            int numberOfAction = rnd.Next(0, whoAttacked.ReturnAvailableActions().Count);

            if (whoAttacked.Curses.Count != 0) // проверка на проклятия
            {
                if (/*!whoAttacked.Curses.Any(x => x.Skipping == true)*/ whoAttacked.CanMove()) // проверка на пропуск хода  
                {
                    UseAction();
                }
                for (int i = 0; i < whoAttacked.Curses.Count; i++)
                {
                    whoAttacked.Health -= whoAttacked.Curses[i].CurseDamage;
                    whoAttacked.Curses[i].CurseDuration--;
                    Logger.WriteLog($"{whoAttacked.Name} пролучил {whoAttacked.Curses[i].CurseDamage} ед. урона от проклятия '{whoAttacked.Curses[i].CurseName}!' {whoAttacked.Curses[i].CurseDuration} осталось");

                    if (whoAttacked.Curses[i].CurseDuration == 0)
                    {
                        whoAttacked.Curses.Remove(whoAttacked.Curses[i]);
                    }
                }
            }
            else
            {
                UseAction();
            }

            void UseAction()
            {
                //whoWasAttacked.Health -= whoAttacked.Actions[numberOfAction].ActionDamage;     // урон
                whoWasAttacked.Health -= whoAttacked.ReturnDamage(whoAttacked.Actions[numberOfAction]);

                if (whoAttacked.Actions[numberOfAction].ActionCurse != null && !whoWasAttacked.Curses.Any(x => x.CurseName == whoAttacked.Actions[numberOfAction].ActionCurse.CurseName))  // добавление проклятия
                {
                    whoAttacked.Actions[numberOfAction].ActionCurse.CurseDuration = whoAttacked.Actions[numberOfAction].ActionCurse.BasicDuration;
                    whoWasAttacked.Curses.Add(whoAttacked.Actions[numberOfAction].ActionCurse);
                }
                whoAttacked.Actions[numberOfAction].ActionRange--;

                Logger.WriteLog($"--{whoAttacked.Name}({whoAttacked.PClass}) применил '{whoAttacked.Actions[numberOfAction].ActionName}' и нанес {whoAttacked.ReturnDamage(whoAttacked.Actions[numberOfAction])} ед. урона! {whoAttacked.Actions[numberOfAction].ActionRange} осталось --");

                if (whoAttacked.Actions[numberOfAction].ActionRange == 0)
                {
                    whoAttacked.EndedActions.Add(whoAttacked.Actions[numberOfAction]);
                    whoAttacked.Actions.Remove(whoAttacked.Actions[numberOfAction]);
                }
            }
        }
        /*public static void GameTurn(Player player1, Player player2)  // игровая очередь
        {
            var Rnd = new Random();
            List<Player> players = new List<Player>{player1, player2}
            List<Player> turn = new List<Player>();
        }*/
    }
}