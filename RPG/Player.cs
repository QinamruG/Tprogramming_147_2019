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
        public bool Sleeping { get; set; } = false;
        public bool Burns { get; set; } = false;
        public string PClass { get; protected set; }
        public int Health { get; set; }
        public string Name { get; protected set; }
        public int Strength { get; protected set; }

        public abstract void Skill(Player Enemy);
        public string Skip()
        {
            return $"{this.Name} пропустил ход";
        }
        public void Attack(Player Enemy)
        {
            if (this.Burns == true)
            {
                this.Health -= 2;
                Logger.WriteLog($"{this.Name} IS OF FIREE!!!");
            }
            int damage = rnd.Next(5, this.Strength);
            Enemy.Health -= damage;
            Logger.Damage(this, Enemy, damage);
        }
    }

}