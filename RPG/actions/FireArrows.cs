using System;

namespace RPG
{
    public class FireArrows : IAction
    {
        const int actRange = 2;
        public string ActionName { get; set; } = "Огненная стрела";
        public int ActionRange { get; set; } = actRange;
        public int BasicRange { get; set; } = actRange;
        public int ActionDamage { get; set; } = 10;
        public ICurse ActionCurse { get; set; } = new Burn();
    }
}