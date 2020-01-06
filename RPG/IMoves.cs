using System;

namespace RPG
{
    interface IMoves
    {
        string PClass{ get; set; }
        void Skill();
        void Attack();
        string Skip();

    }
}