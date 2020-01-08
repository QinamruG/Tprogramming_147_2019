using System;
using System.Collections.Generic;
namespace RPG
{
    class Knight : Player
    {
        List<string> names = new List<string>() { "Яков", "Родерик", "Зигфрид", "Вернон", "Артур", "Ариан", "Дхойне" };
        public Knight() : base()
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Рыцарь";
        }
        /*public Knight() : base(enemy)
        {
            Name = names[rnd.Next(0, names.Count)];
            PClass = "Рыцарь";
        }*/
        public override void Skill()
        {
            /*Enemy.Health -= Convert.ToInt32(Math.Round(this.Strength * 1.3));*/
        }
    }

}