using System;
using System.Collections.Generic;

namespace RPG
{
    public static class Fight
    {
        public static void Attack(Player whoAttacked, Player whoWasAttacked)
        {
            var Rnd = new Random();
            var attackOrUseSkill = Rnd.Next(1, 10);
            if (whoAttacked.Sleeping <= 0)
            {
                if (attackOrUseSkill < 6)
                {
                    whoAttacked.Attack(whoWasAttacked);
                }
                else
                {
                    whoAttacked.Skill(whoWasAttacked);
                }
            }
            else
            {
                whoAttacked.Skip();
            }
        }
    }
}