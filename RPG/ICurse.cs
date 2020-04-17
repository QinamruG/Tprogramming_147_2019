namespace RPG
{
    public interface ICurse : IBaseAction
    {
        bool Skipping { get; set; }      // пропуск хода
    }
}