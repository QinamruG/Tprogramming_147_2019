using System;
using System.Collections.Generic;

namespace RPG
{
    public interface IMoves
    {
        void Skill(Player Enemy);
        void Attack(Player Enemy);
        void Skip();
    }
}