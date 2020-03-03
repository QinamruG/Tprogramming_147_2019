using System;
namespace RPG
{
    public  class ArcherSkills : ISkill
    {
        public void Skill(Player This, Player Enemy)
        {
            var rnd = new Random();
            int n = rnd.Next(0, 1);
            if (Enemy.Burns == true)
            {
                This.Hit(Enemy);
            }
            switch (n)
            {
                case 0:
                    this.Skill1(This, Enemy);
                    break;
            }

        }
        void Skill1(Player This, Player Enemy)
        {
            Enemy.Burns = true;
            Enemy.Health -= 2;
            Logger.WriteLog($"Лучник {This.Name} искользует огненные стрелы против {Enemy.Name}({Enemy.PClass})!");
        }
    }
}