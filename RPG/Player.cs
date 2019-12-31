using System;

namespace RPG
{
    public abstract class Player : IMoves
    {
        private int health;
        private int strenght;
        public Player Enemy;
        public Player()
        {
        }
        public Player(string name, int health, int strength, string pClass)
        {
            Name = name;
            Strength = strength;
            Health = health;
            PClass = pClass;
        }

        public string PClass{ get; set; }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value > 0)
                {
                    this.health = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("U can't enter 0 or less health");
                }
            }
        }
        public string Name { get; set; }
        public int Strength
        {
            get
            {
                return this.strenght;
            }
            set
            {
                if (value > 0)
                {
                    this.strenght = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("U can't enter 0 or less strenght");
                }
            }
        }

        public abstract void Skill();
        public string Skip()
        {
            return $"{this.Name} пропустил ход";
        }
        public int Attack()
        {
            Enemy.Health -= this.Strength;
        }
    }

}