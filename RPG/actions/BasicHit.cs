using System;
namespace RPG
{
    public class BasicHit : IAction
    {
        public BasicHit()
        {
            Damage = rnd.Next(10, 50);
        }

        Random rnd = new Random();
        const int actRange = -1;
        public string Name { get; set; } = "Обычный удар";
        public int Range { get; set; } = actRange; // допустимое кол-во использований
        public int BaseRange { get; set; } = actRange;
        public int Damage { get; set; } = 1;
        public ICurse Curse { get; set; } = null;

    }
}