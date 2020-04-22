using System;
using System.Collections.Generic;

namespace RPG
{
    public class Archer : Player
    {
        List<string> names = new List<string>() { "Алмиэль", "НеДхойне", "Яевинн", "Йорвет", "Элеас", "Малена", "Хириадан" };
        public Archer(): base()
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Лучник";
            Name = names[rnd.Next(0, names.Count)];
        }
        public Archer(int strenght, int hp, string name) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Лучник";
            Name = name;
        }
        public Archer(int strenght, int hp) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new Euthanasia(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Лучник";
            Name = names[rnd.Next(0, names.Count)];
        }
    }
}