namespace RPG
{
    public class Burn : ICurse
    {
        public Burn()
        {
            CurseDuration = 3;
        }
        public string CurseName { get; set; } = "Огонь";
        public int CurseDamage { get; set; } = 2;
        public int CurseDuration { get; set; } = 3;
        public int BasicDuration { get; set; } = 3;
        public bool Skipping { get; set; } = false;
    }
}