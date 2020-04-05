using System;
using System.Collections.Generic;

namespace RPG
{
    public abstract class Player
    {
        protected Random rnd = new Random();
        public Player()
        {
            Strength = rnd.Next(10, 25);
            Health = rnd.Next(70, 120);
        }
        public string PClass { get; protected set; }
        public int Health { get; set; }
        public string Name { get; protected set; }
        public int Strength { get; protected set; } // нужна ли ?
        public List<IAction> Actions { get; set; } // его умения
        public List<IAction> EndedActions { get; set; }
        public List<ICurse> Curses { get; set; } // наложенные на него проклятия

        /*public void UseAction(List<IAction> actions)
        {
            if(actions[rnd.Next(0,actions.Count)].ActionRange != 0)
            {
                
            }
        }*/
    }
}