using System;

namespace CourseApp
{
    public class Picture : PieceOfArt
    {
        private int year;

        public Picture()
        : this(0, "Untitled", "No country")
        {
        }

        public Picture(int prodYear, string name, string country)
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
                if (value >= 0 && value <= DateTime.Now.Year)
                {
                    this.year = value;
                }
                else
                {
                    throw new System.Exception($"Production year should be > 0 and < than {DateTime.Now.Year}");
                }
            }
        }

        public override string Watch()
        {
            return $"Now i am watching a picture, named {Name}, which was painted in {ProdYear} in {Country}";
        }

        public override string Mark(int mark)
        {
            switch (mark)
            {
                case 1:
                    return $"{Name} is terrible, artist need to be locked in a madhouse ";

                case 2:
                    return $"Ok,{Name} looks like fan art from internet ...";

                case 3:
                    return $"{Name} is a masterpeace!!! I want to go to the {Country} and shake hands with the artist!";

                default:
                    return "Wuh? What picture? Where?";
            }
        }

        public override string Send(string toWho)
        {
            return $"Hi {toWho}, can you check {Name}? I want to know your opinion about this picture";
        }

        public override string ToString()
        {
            return $"Name:{Name}, Production year:{ProdYear}, Country:{Country}";
        }
    }
}