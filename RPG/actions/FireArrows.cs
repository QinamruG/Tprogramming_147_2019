using System;

namespace RPG
{
    public class FireArrows : IAction
    {
        public string ActionName { get; set; } = "Огненная стрела";
        public int ActionRange { get; set; } = 1;
        public int ActionDamage { get; set; } = 10;
        public int ActionDuration { get; set; } = 3;
        public string curse = "Огонь";
        public ICurse ActionCurse { get; set; } = new Burn();

        /*void Action(Player This, Player Enemy)
        {
            Enemy.Burns = true;
            Enemy.Health -= 2;
            Logger.WriteLog($"Лучник {This.Name} искользует огненные стрелы против {Enemy.Name}({Enemy.PClass})!");
        }*/
    }
}