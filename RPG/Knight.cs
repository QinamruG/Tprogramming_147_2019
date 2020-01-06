using System;

namespace RPG
{
    class Knight : Player
    {
        public Knight()
        {

        }
        public Knight(string name, int health, int strength):base(name, health, strength)
        {

        }
        public override void Skill()
        {
            Enemy.Health -= Convert.ToInt32(Math.Round(this.Strength * 1.3));
        }
    }

}