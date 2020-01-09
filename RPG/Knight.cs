using System;
using System.Collections.Generic;
namespace RPG
{
    public class Knight : Player
    {
        List<string> names = new List<string>() { "Яков", "Родерик", "Зигфрид", "Вернон", "Артур", "Ариан", "Дхойне" };
        public Knight() : base()
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Рыцарь";
        }

        public override void Skill(Player Enemy)
        {
            Enemy.Health -= Convert.ToInt32(Math.Round(this.Strength * 1.3));
            Logger.WriteLog($"Рыцарь {this.Name} применяет удар возмездия на {Enemy.Name}({Enemy.PClass})!");
        }
    }

}