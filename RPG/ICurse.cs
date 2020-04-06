namespace RPG
{
    public interface ICurse
    {
        string CurseName { get; set; }   // название проклятия
        int CurseDamage { get; set; }    // урон от проклятия
        int CurseDuration { get; set; }  // продолжительность эффекта
        int BasicDuration { get; set; }  // изначальная продолжительность
        bool Skipping { get; set; }      // пропуск хода
    }
}