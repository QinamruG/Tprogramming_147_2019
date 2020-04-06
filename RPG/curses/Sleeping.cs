namespace RPG
{
    public class Sleeping : ICurse
    {
        public Sleeping()
        {
            CurseDuration = 2;
        }
        public string CurseName { get; set; } = "Сон";
        public int CurseDamage { get; set; } = 0;
        public int CurseDuration { get; set; } = 2;
        public int BasicDuration { get; set; } = 2;
        public bool Skipping { get; set; } = true;
    }
}