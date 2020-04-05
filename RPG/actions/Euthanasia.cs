using System;

namespace RPG
{
    public class Euthanasia : IAction
    {
        const int actRange = 2;
        public string ActionName { get; set; } = "Усыпление";
        public int ActionRange { get; set; } = actRange;
        public int BasicRange { get; set; } = actRange;
        public int ActionDamage { get; set; } = 5;
        public ICurse ActionCurse { get; set; } = new Sleeping();
    }
}