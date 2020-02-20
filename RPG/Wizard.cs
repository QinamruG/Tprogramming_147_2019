using System;
using System.Collections.Generic;

namespace RPG
{
    public class Wizard : Player
    {
        List<string> names = new List<string>() { "Трисс", "Шеала", "Йеннифер", "Сабрина", "Демавенд", "Кейра", "Марквар" };
        public Wizard() : base()
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Чародей";
        }

        public override void Skill(Player Enemy)
        {
            Enemy.Sleeping = true;
            Logger.WriteLog($"Чародей {this.Name} усыпил {Enemy.Name}({Enemy.PClass})!"); 
        }
    }
}