using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public abstract class Player
    {
        protected Random rnd = new Random();
        public Player(int strenght, int hp)
        {
            Strength = strenght;
            Health = hp;
        }
        public Player() : this(rnd.Next(10, 25), rnd.Next(70, 120))
        {
        }
        public string PClass { get; protected set; }
        public int Health { get; set; }
        public string Name { get; protected set; }
        public int Strength { get; protected set; } // нужна ли ?
        protected List<IAction> Actions { get; set; }  // его умения
        protected List<IAction> EndedActions { get; set; }
        protected List<ICurse> Curses { get; set; }   // наложенные на него проклятия

        public int ReturnDamage(IAction action)
        {
            return Convert.ToInt16(action.ActionDamage * Math.Log10(this.Strength));
        }

        public int GetDamage(IAction action)
        {
            // 1 - применитб урон (с учетом силы того, кто ударил)
            this.Health -= action.Damage;           
            // Необходимо применить пассивный урон от всех уже наложенных проклятий
            foreach(var curse in this.Curses)
            {
                this.Health -= curse.Damage;
                // проверять не закончилось ли действие проклятия и удалять его
            }    

            if (action.Curse)
            {
                this.Curses.Add(action.Curse);
            }

        }

        public List<IAction> ReturnAvailableActions()
        {
            var a = this.Actions;
            a.RemoveAll(x => x.ActionRange == 0);
            return a;
        }

        public ICurse ReturnCurse(IAction action)
        {
            if (action.ActionCurse != null)
            {
                return action.ActionCurse;
            }
            else
            {
                return null;
            }
        }
        public bool CanMove()
        {
            if (!this.Curses.Any(x => x.Skipping == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        IAction GetAction()
        {

            //Проверить Curse - нет ли заклятия пропуска хода
            if (this.CanMove())
            {
                var i = rnd.Next(0, this.Actions.Count);
                // у Action'a должна учитываться сила игрока
                // проверить - не надо ли удалить из-за того, что счетчик использований закончился
                return this.Actions[i];
            }
            return null;
        }


        /*public void UseAction(List<IAction> actions)
        {
            if(actions[rnd.Next(0,actions.Count)].ActionRange != 0)
            {
                
            }
        }*/
    }
}