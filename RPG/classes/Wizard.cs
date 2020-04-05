using System;
using System.Collections.Generic;

namespace RPG
{
    public class Wizard : Player
    {
        List<string> names = new List<string>() { "Трисс", "Шеала", "Йеннифер", "Сабрина", "Демавенд", "Кейра", "Марквар" };

        public Wizard() : base()
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Чародей";
        }
    }
}