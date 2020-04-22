using System;

namespace RPG
{
    public class FireArrows : IAction
    {
        const int actRange = 2;
        public string Name { get; set; } = "Огненная стрела";
        public int Range { get; set; } = actRange;
        public int BaseRange { get; set; } = actRange;
        public int Damage { get; set; } = 10;
        public ICurse Curse { get; set; } = new Burn();
    }
}