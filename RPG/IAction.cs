namespace RPG
{
    public interface IAction
    {
        string ActionName { get; set; }  // название умения
        int ActionRange { get; set; }    // допустимое кол-во использований
        int BasicRange { get; set; }     // изначальное кол-во использований, нужно для восстановления после сражения
        int ActionDamage { get; set; }   // урон от умения
        ICurse ActionCurse { get; set; } // проклятие
    }
}