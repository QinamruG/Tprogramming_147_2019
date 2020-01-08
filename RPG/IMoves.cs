using System;
using System.Collections.Generic;

namespace RPG
{
    interface IMoves
    {
        void Skill();
        void Attack(Player Enemy);
        string Skip();

    }
}