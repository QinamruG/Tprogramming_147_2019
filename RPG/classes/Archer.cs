using System;
using System.Collections.Generic;

namespace RPG
{
    public class Archer : Player
    {
        List<string> names = new List<string>() { "Алмиэль", "НеДхойне", "Яевинн", "Йорвет", "Элеас", "Малена", "Хириадан" };
        public Archer() : base()
        {
            Actions = new List<IAction>() { new BasicHit(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Лучник";
        }
    }
}