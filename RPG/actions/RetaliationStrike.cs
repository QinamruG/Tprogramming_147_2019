using System;
namespace RPG
{
    public class RetaliationStrike : IAction
    {
        public RetaliationStrike()
        {
            ActionDamage = Convert.ToInt32(rnd.Next(10, 50) * 1.3);
        }
        Random rnd = new Random();
        const int actRange = 2;
        public string ActionName { get; set; } = "Удар возмездия";
        public int ActionRange { get; set; } = actRange; // допустимое кол-во использований
        public int BasicRange { get; set; } = actRange;
        public int ActionDamage { get; set; } = 1;
        public ICurse ActionCurse { get; set; } = null;

    }
}