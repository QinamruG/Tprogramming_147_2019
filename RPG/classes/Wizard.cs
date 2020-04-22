using System;
using System.Collections.Generic;

namespace RPG
{
    public class Wizard : Player
    {
        List<string> names = new List<string>() { "Трисс", "Шеала", "Йеннифер", "Сабрина", "Демавенд", "Кейра", "Марквар" };

        public Wizard() : base()
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Чародей";
            Name = names[rnd.Next(0, names.Count)];
        }
        public Wizard(int strenght, int hp, string name) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Чародей";
            Name = name;
        }
        public Wizard(int strenght, int hp) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Чародей";
            Name = names[rnd.Next(0, names.Count)];
        }

        /*        public Wizard(int strenght, int hp) : this(strenght, hp, names[rnd.Next(0, names.Count)])
                {
                }
                public Wizard() : this(rnd.Next(10, 25), rnd.Next(70, 120))
                {
                }*/
    }
}