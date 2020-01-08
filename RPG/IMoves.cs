using System;
using System.Collections.Generic;

namespace RPG
{
    interface IMoves
    {
        void Skill(Player Enemy);
        void Attack(Player Enemy);
        string Skip();

    }
}