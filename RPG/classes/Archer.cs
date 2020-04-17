using System;
using System.Collections.Generic;

namespace RPG
{
    public class Archer : Player
    {
        List<string> names = new List<string>() { "Алмиэль", "НеДхойне", "Яевинн", "Йорвет", "Элеас", "Малена", "Хириадан" };
        public Archer(int strenght, int hp, string name) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new FireArrows(), new Euthanasia() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            Name = name;
            PClass = "Лучник";
        }
        public Archer(int strenght, int hp) : this(strenght, hp, names[rnd.Next(0, names.Count)])
        {
        }
        public Archer() : this(rnd.Next(10, 25), rnd.Next(70, 120))
        {
        }
    }
}