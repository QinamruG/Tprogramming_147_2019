using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public static class Fight
    {
        public static void Attack(Player whoAttacked, Player whoWasAttacked)  // атака
        {
            if (whoAttacked.CanMove())
            {
                var attackAction = whoAttacked.GetAction(); // Запрашиваем атаку

                if (attackAction != null)
                {
                    var damage = whoWasAttacked.GetDamage(attackAction, whoAttacked.Name, whoAttacked.ReturnDamage(attackAction));   // Передаем атаку атакуемому
                    Logger.WriteLog($"---{whoAttacked.Name} использовал способность {attackAction.Name} и нанес {damage} ед. урона ... ({attackAction.Range} осталось)---");
                    // логгер с проклятиями обрабатывается в методе игрока 
                }
            }
            else
            {
                Logger.WriteLog($"___{whoAttacked.Name} пропустил ход___");
            }
        }
    }
}