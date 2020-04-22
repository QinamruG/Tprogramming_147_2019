namespace RPG
{
    public class Burn : ICurse
    {
        public Burn()
        {
            Range = 3;
        }
        public string Name { get; set; } = "Огонь";
        public int Damage { get; set; } = 2;
        public int Range { get; set; } = 3;
        public int BaseRange { get; set; } = 3;
        public bool Skipping { get; set; } = false;
    }
}