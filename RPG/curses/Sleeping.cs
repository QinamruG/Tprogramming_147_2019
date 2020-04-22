namespace RPG
{
    public class Sleeping : ICurse
    {
        public Sleeping()
        {
            Range = 2;
        }
        public string Name { get; set; } = "Сон";
        public int Damage { get; set; } = 0;
        public int Range { get; set; } = 2;
        public int BaseRange { get; set; } = 2;
        public bool Skipping { get; set; } = true;
    }
}