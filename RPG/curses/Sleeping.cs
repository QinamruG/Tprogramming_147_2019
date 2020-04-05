namespace RPG
{
    public class Sleeping : ICurse
    {
        public Sleeping()
        {
            CurseDuration = 1;
        }
        public string CurseName { get; set; } = "Сон";
        public int CurseDamage { get; set; } = 0;
        public int CurseDuration { get; set; } = 1;
        public bool Skipping { get; set; } = true;
    }
}