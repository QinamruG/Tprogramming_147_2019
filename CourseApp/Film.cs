using System;

namespace CourseApp
{
    public class Film : PieceOfArt
    {
        private int year;

        public Film()
        : this(1888, "Untitled", "No country")
        {
        }

        public Film(int prodYear, string name, string country)
        : base(prodYear, name, country)
        {
        }

        public override int ProdYear
        {
            get
            {
                return this.year;
            }

            set
            {
                if (value >= 1888 && value <= DateTime.Now.Year)
                {
                    this.year = value;
                }
                else
                {
                    throw new System.Exception($"Production year should be > 1888 and < than {DateTime.Now.Year}");
                }
            }
        }

        public override string Watch()
        {
            return $"Now i am watching a film, named {Name}, which came out in {ProdYear} from {Country}";
        }

        public override string Mark(int mark)
        {
            switch (mark)
            {
                case 1:
                    return $"{Name} is terrible film, dont watch it never!!!!!! ";

                case 2:
                    return $"Ok,{Name} not good not bad, for an amateur...";

                case 3:
                    return $"{Name} is a masterpeace!!! I want to {Country} to take a look at those places!!!";

                default:
                    return "HI-hi-hi im not watched this film";
            }
        }

        public override string Send(string toWho)
        {
            return $"Hi {toWho}, can you check {Name}({ProdYear}) to watch? I want to know your opinion about this film))";
        }

        public override string ToString()
        {
            return $"Name:{Name}, Production year:{ProdYear}, Country:{Country}";
        }
    }
}