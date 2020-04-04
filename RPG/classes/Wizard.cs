using System;
using System.Collections.Generic;

namespace RPG
{
    public class Wizard : Player
    {
        List<string> names = new List<string>() { "Трисс", "Шеала", "Йеннифер", "Сабрина", "Демавенд", "Кейра", "Марквар" };
        // public List<IAction> Actions { get; set; } = new List<IAction>() { new BasicHit() };
        // public List<ICurse> Curses { get; set; } = new List<ICurse>();
        public Wizard() : base()
        {
            //Actions =  new List<IAction>(){new BasicHit()};
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Чародей";
        }

        /*public override void Skill(Player Enemy)
        {
            Enemy.Sleeping = 2;
            Logger.WriteLog($"Чародей {this.Name} применил заклинание усыпления на  {Enemy.Name}({Enemy.PClass})!");
        }*/
    }
}