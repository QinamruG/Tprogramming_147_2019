using System;

namespace RPG
{
    class Archer : Player
    {
        public Archer()
        {

        }
        public Archer(string name, int health, int strength):base(name, health, strength)
        {

        }
        public override void Skill()
        {
            Enemy.Skip();
            Enemy.Health -=2;
        }
    }

}