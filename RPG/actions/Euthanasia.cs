using System;

namespace RPG
{
    public class Euthanasia : IAction
    {
        const int actRange = 2;
        public string Name { get; set; } = "Усыпление";
        public int Range { get; set; } = actRange;
        public int BaseRange { get; set; } = actRange;
        public int Damage { get; set; } = 5;
        public ICurse Curse { get; set; } = new Sleeping();
    }
}