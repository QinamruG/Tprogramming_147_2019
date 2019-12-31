using System;

namespace RPG
{
    interface IMoves
    {
        string PClass{ get; set; }
        void Skill();
        int Attack();
        string Skip();

    }
}