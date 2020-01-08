using System;
using System.Collections.Generic;

namespace RPG
{
    public abstract class Player : IMoves
    {
        Logger LogText = new Logger();
        //public string plClass;
        protected Random rnd = new Random();
        private int health;
        private int strenght;
        //public Player Enemy {get; set; }
        public Player()
        {
            Strength = rnd.Next(10, 30);
            Health = rnd.Next(10, 70);
        }
        /*public Player(Player enemy)
        {
            //Enemy = enemy;
            Strength = rnd.Next(5, 15);
            Health = rnd.Next(10, 100);
        }*/

        public string PClass { get; protected set; }
        public int Health { get; set; }
        public string Name { get; protected set; }
        public int Strength { get; protected set; }

        public abstract void Skill();
        public string Skip()
        {
            return $"{this.Name} пропустил ход";
        }
        public void Attack(Player Enemy)
        {
            int damage = rnd.Next(5,this.Strength);
            Enemy.Health -= damage;
            LogText.Damage(this,Enemy,damage);
        }
    }

}