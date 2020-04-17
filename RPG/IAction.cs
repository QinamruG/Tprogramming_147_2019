namespace RPG
{
    public interface IAction : IBaseAction
    {
        ICurse Curse { get; set; } // проклятие
    }
}