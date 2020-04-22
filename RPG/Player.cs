using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public abstract class Player
    {
        protected int baseHP;
        protected Random rnd = new Random();
        public Player()
        {
            Strength = rnd.Next(10, 25);
            Health = rnd.Next(70, 120);
            baseHP = Health;
        }
        public Player(int strenght, int hp)
        {
            Strength = strenght;
            Health = hp;
            baseHP = Health;
        }
        public string PClass { get; protected set; }
        public int Health { get; set; }
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        protected List<IAction> Actions { get; set; }  // его умения
        protected List<IAction> EndedActions { get; set; }
        protected List<ICurse> Curses { get; set; }   // наложенные на него проклятия

        public IAction GetAction()
        {
            if (this.CanMove())  // Проверить Curse - нет ли заклятия пропуска хода
            {
                var numberOfAction = rnd.Next(0, this.ReturnAvailableActions().Count);

                this.Actions[numberOfAction].Damage = ReturnDamage(this.Actions[numberOfAction]);  // у Action'a должна учитываться сила игрока

                this.Actions[numberOfAction].Range--;        // проверить - не надо ли удалить из-за того, что счетчик использований закончился
                if (this.Actions[numberOfAction].Range == 0)
                {
                    this.EndedActions.Add(this.Actions[numberOfAction]);
                    /*this.Actions.Remove(this.Actions[numberOfAction]);
                    return null;*/
                }
                return this.Actions[numberOfAction];
            }
            return null;
        }
        public int GetDamage(IAction action)
        {
            this.Health -= action.Damage;
            Logger.WriteLog($"{this.Name} получил {action.Damage} ед. урона от способности {action.Name} {action.Range} осталось");

            foreach (var curse in this.Curses)  // Необходимо применить пассивный урон от всех уже наложенных проклятий
            {
                this.Health -= curse.Damage;
                curse.Range--;
                Logger.WriteLog($"Проклятье {curse.Name} нанесло {curse.Damage} ед. урона {curse.Range} осталось");
            }
            this.Curses.RemoveAll(x=>x.Range == 0);

            if (action.Curse != null)
            {
                this.Curses.Add(action.Curse);
            }
            return action.Damage;
        }
        public void ReturnToBasic()
        {
            this.Curses.Clear();
            this.Actions.AddRange(this.EndedActions);
            this.EndedActions.Clear();
            for (int i = 0; i < this.Actions.Count; i++)
            {
                this.Actions[i].Range = this.Actions[i].BaseRange;
                if (this.Actions[i].Curse != null)
                {
                    this.Actions[i].Curse.Range = this.Actions[i].Curse.BaseRange;
                }
            }
            this.Health = baseHP;
        }
        public int ReturnDamage(IAction action)
        {
            return Convert.ToInt16(action.Damage * Math.Log10(this.Strength));
        }
        public void GetCurse(ICurse curse)
        {
            this.Curses.Add(curse);
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
        protected List<IAction> ReturnAvailableActions()
        {
            // var a = this.Actions;
            this.Actions.RemoveAll(x => x.Range == 0);
            return this.Actions;
        }
    }
}