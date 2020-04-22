using System;
using System.Collections.Generic;
namespace RPG
{
    public class Knight : Player
    {
        List<string> names = new List<string>() { "Яков", "Родерик", "Зигфрид", "Вернон", "Артур", "Ариан", "Дхойне" };

        public Knight(): base()
        {
            Actions = new List<IAction>() { new BasicHit(), new RetaliationStrike(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Рыцарь";
            Name = names[rnd.Next(0, names.Count)];
        }
        public Knight(int strenght, int hp, string name) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new RetaliationStrike(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Рыцарь";
            Name = name;
        }
        public Knight(int strenght, int hp) : base(strenght, hp)
        {
            Actions = new List<IAction>() { new BasicHit(), new RetaliationStrike(), new FireArrows() };
            Curses = new List<ICurse>();
            EndedActions = new List<IAction>();
            PClass = "Рыцарь";
            Name = names[rnd.Next(0, names.Count)];
        }
    }

}