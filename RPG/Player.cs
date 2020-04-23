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
            Health = rnd.Next(80, 150);
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

                //this.Actions[numberOfAction].Damage = ReturnDamage(this.Actions[numberOfAction]);  // у Action'a должна учитываться сила игрока

                this.Actions[numberOfAction].Range--;        // проверить - не надо ли удалить из-за того, что счетчик использований закончился

                if (this.Actions[numberOfAction].Range == 0)
                {
                    this.EndedActions.Add(this.Actions[numberOfAction]);
                }
                return this.Actions[numberOfAction];
            }
            return null;
        }
        public int GetDamage(IAction action, string enemyName, int damage)
        {
            this.Health -= damage; // action.Damage;
            //Logger.WriteLog($"{this.Name} получил {action.Damage} ед. урона от способности {action.Name} ({action.Range} осталось)");
            //Logger.WriteLog($"--{enemyName} применил '{action.Name}' и нанес {action.Damage} ед. урона! {action.Range} осталось --");

            foreach (var curse in this.Curses)  // Необходимо применить пассивный урон от всех уже наложенных проклятий
            {
                this.Health -= curse.Damage;
                curse.Range--;
                Logger.WriteLog($"{this.Name} получил {curse.Damage} ед. урона от эффекта'{curse.Name}' ({curse.Range} осталось)");
            }
            if (action.Curse != null && !this.Curses.Any(x => x.Name == action.Curse.Name))
            {
                this.Curses.Add(action.Curse);
            }
            this.Curses.RemoveAll(x => x.Range == 0);

            return action.Damage;
        }
        public void ReturnToBasic()
        {
            this.Curses.Clear();
            this.Actions.AddRange(this.EndedActions);
            this.EndedActions.Clear();

            foreach (var action in this.Actions)
            {
                action.Range = action.BaseRange;
                if (action.Curse != null)
                {
                    action.Curse.Range = action.Curse.BaseRange;
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
            this.Actions.RemoveAll(x => x.Range == 0);

            return this.Actions;
        }
    }
}