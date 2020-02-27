using System;
using System.Collections.Generic;

namespace RPG
{
    public class Archer : Player
    {
        Skills[] skillArray = new Player.Skills[]
        {
            (enemy) =>
            {
                enemy.Health -=10;
                Logger.WriteLog("ДЕЛЕГАТ ");
            }
        };
        List<string> names = new List<string>() { "Алмиэль", "НеДхойне", "Яевинн", "Йорвет", "Элеас", "Малена", "Хириадан" };
        public Archer() : base()
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Лучник";
        }

        public override void Skill(Player Enemy)
        {
            skillArray[0](Enemy);
            if (Enemy.Burns == true)
            {
                this.Hit(Enemy);
            }
            else
            {
                Enemy.Burns = true;
                Enemy.Health -= 2;
                Logger.WriteLog($"Лучник {this.Name} искользует огненные стрелы против {Enemy.Name}({Enemy.PClass})!");
            }
        }
    }
}