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
            if (whoAttacked.CanMove())
            {
                var attackAction = whoAttacked.GetAction(); // 1 - Мы запрашиваем у Игрока - дай мне атаку
                if (attackAction != null)
                {
                    whoWasAttacked.GetDamage(attackAction);   // Передаем атаку атакуемому - просим сказать сколько он получил урона / осталось жизни
                }
            }
            else
            {
                Logger.WriteLog($"{whoAttacked.Name} пропустил ход ");
                // Лог про пропуск хода
            }
            // Вот тут заканчивается этот метод




            /*  var rnd = new Random();
              //var availableActions = whoAttacked.Actions.FindAll(x => x.ActionRange != 0);
              //var availableActions = whoAttacked.ReturnAvailableActions();
              int numberOfAction = rnd.Next(0, whoAttacked.ReturnAvailableActions().Count);

              if (whoAttacked.Curses.Count != 0) // проверка на проклятия
              {
                  if (whoAttacked.CanMove()) // проверка на пропуск хода  
                  {
                      UseAction();
                  }
                  for (int i = 0; i < whoAttacked.Curses.Count; i++)
                  {
                      whoAttacked.Health -= whoAttacked.Curses[i].Damage;
                      whoAttacked.Curses[i].Range--;
                      Logger.WriteLog($"{whoAttacked.Name} пролучил {whoAttacked.Curses[i].Damage} ед. урона от проклятия '{whoAttacked.Curses[i].Name}!' {whoAttacked.Curses[i].Range} осталось");

                      if (whoAttacked.Curses[i].Range == 0)
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

                  if (whoAttacked.Actions[numberOfAction].Curse != null && !whoWasAttacked.Curses.Any(x => x.Name == whoAttacked.Actions[numberOfAction].Curse.Name))  // добавление проклятия
                  {
                      whoAttacked.Actions[numberOfAction].Curse.Range = whoAttacked.Actions[numberOfAction].Curse.BaseRange;
                      whoWasAttacked.Curses.Add(whoAttacked.Actions[numberOfAction].Curse);
                  }
                  whoAttacked.Actions[numberOfAction].Range--;

                  Logger.WriteLog($"--{whoAttacked.Name}({whoAttacked.PClass}) применил '{whoAttacked.Actions[numberOfAction].Name}' и нанес {whoAttacked.ReturnDamage(whoAttacked.Actions[numberOfAction])} ед. урона! {whoAttacked.Actions[numberOfAction].Range} осталось --");

                  if (whoAttacked.Actions[numberOfAction].Range == 0)
                  {
                      whoAttacked.EndedActions.Add(whoAttacked.Actions[numberOfAction]);
                      whoAttacked.Actions.Remove(whoAttacked.Actions[numberOfAction]);
                  }
              }*/
        }
        /*public static void GameTurn(Player player1, Player player2)  // игровая очередь
        {
            var Rnd = new Random();
            List<Player> players = new List<Player>{player1, player2}
            List<Player> turn = new List<Player>();
        }*/
    }
}