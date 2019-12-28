using System;

namespace RPG
{
    public abstract class Player
    {
        private int health;
        private int strenght;
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

    }

}