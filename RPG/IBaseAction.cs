namespace RPG
{
    public interface IBaseAction
    {
        string Name { get; set; }  // название умения
        int Range { get; set; }    // допустимое кол-во использований
        int Count { get; set; }     // изначальное кол-во использований, нужно для восстановления после сражения
        int Damage { get; set; }   // урон от умения
    }
}