using System;
namespace RPG
{
    public class RetaliationStrike : IAction
    {
        public RetaliationStrike()
        {
            Damage = Convert.ToInt32(rnd.Next(10, 50) * 1.3);
        }
        Random rnd = new Random();
        const int actRange = 2;
        public string Name { get; set; } = "Удар возмездия";
        public int Range { get; set; } = actRange; // допустимое кол-во использований
        public int BaseRange { get; set; } = actRange;
        public int Damage { get; set; } = 1;
        public ICurse Curse { get; set; } = null;

    }
}