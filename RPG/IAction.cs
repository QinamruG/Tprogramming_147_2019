namespace RPG
{
    public interface IAction
    {
        string ActionName { get; set; } // название умения
        int ActionRange { get; set; } // допустимое кол-во использований
        int ActionDamage { get; set; } // урон от умения
        ICurse ActionCurse { get; set; }
    }
}