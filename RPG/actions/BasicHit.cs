using System;
namespace RPG
{
    public class BasicHit : IAction
    {
        public BasicHit()
        {
            ActionDamage = rnd.Next(10, 50);
        }

        Random rnd = new Random();
        const int actRange = -1;
        public string ActionName { get; set; } = "Обычный удар";
        public int ActionRange { get; set; } = actRange; // допустимое кол-во использований
        public int BasicRange { get; set; } = actRange;
        public int ActionDamage { get; set; } = 1;
        public ICurse ActionCurse { get; set; } = null;

    }
}