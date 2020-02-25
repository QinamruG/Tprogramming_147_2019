using System;
using System.Collections.Generic;

namespace RPG
{
    public abstract class Player : IMoves
    {
        protected Random rnd = new Random();
        public Player()
        {
            Strength = rnd.Next(10, 25);
            Health = rnd.Next(25, 70);
        }
        public int Sleeping { get; set; } = 0;
        public bool Burns { get; set; } = false;
        public string PClass { get; protected set; }
        public int Health { get; set; }
        public string Name { get; protected set; }
        public int Strength { get; protected set; }

        public abstract void Skill(Player Enemy);
        public void Skip()
        {
            if (this.Sleeping == 1)
                Logger.WriteLog($"*{this.Name} пропустил ход*");
            this.Sleeping -= 1;
        }
        public void Attack(Player Enemy)
        {
            if (this.Burns == true)
            {
                this.Health -= 2;
                Logger.WriteLog($"*{this.Name} получил 2 ед. урона от огня*");
            }
            int damage = rnd.Next(5, this.Strength);
            Enemy.Health -= damage;
            Logger.Damage(this, Enemy, damage);
        }
    }

}