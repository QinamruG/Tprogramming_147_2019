namespace RPG
{
    public class Sleeping : ICurse
    {
        public string CurseName { get; set; } = "Усыпление";
        public int CurseRange { get; set; } = 5;
        public int CurseDamage { get; set; } = 0;
        public int CurseDuration { get; set; } = 2;
        public bool Skipping { get; set; } = true;
    }
}