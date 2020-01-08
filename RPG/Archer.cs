using System;
using System.Collections.Generic;

namespace RPG
{
    class Archer : Player
    {
        List<string> names = new List<string>() { "Алмиэль", "НеДхойне", "Яевинн", "Йорвет", "Элеас", "Малена", "Хириадан" };
        public Archer() : base()
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Лучник";
        }

        /*public Archer() : base(enemy)
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Лучник";
        }*/
        public override void Skill()
        {
            /*Enemy.Skip();
            Enemy.Health -= 2;*/
        }
    }
}