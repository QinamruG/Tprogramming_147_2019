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
        public string ActionName { get; set; } = "Обычный удар";
        public int ActionRange { get; set; } = -1; // допустимое кол-во использований
        public int ActionDamage { get; set; } = 1;
        public ICurse ActionCurse { get; set; } = null;

    }
}