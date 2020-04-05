namespace RPG
{
    public interface ICurse
    {
        string CurseName { get; set; }   // название проклятия
        int CurseDamage { get; set; }    // урон от проклятия
        int CurseDuration { get; set; }  // продолжительность эффекта
        bool Skipping { get; set; }      // пропуск хода
    }
}