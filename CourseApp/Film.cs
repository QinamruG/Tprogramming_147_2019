using System;

namespace CourseApp
{
    public class Film
    {
        private int year;

        public Film()
        : this(1888, "Untitled", "No country")
        {
        }

        public Film(int year, string name, string country)
        {
            Name = name;
            ProdYear = year;
            Country = country;
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public int ProdYear
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
                    // throw new System.ArgumentException($"Production year should be > 1888 and < than {DateTime.Now.Year}");
                    Console.WriteLine($"Production year should be > 1888 and < than {DateTime.Now.Year}");
                }
            }
        }

        public string WatchFilm()
        {
        return $"Now i am watching a film, named {Name}, which came out in {ProdYear} from {Country}";
        }

        public string MarkFilm(int mark)
        {
           switch (mark)
           {
               case 1:

               //Console.WriteLine($"{Name} is terrible film, dont watch it never!!!!!! ");
               return $"{Name} is terrible film, dont watch it never!!!!!! ";

               // Console.WriteLine($"Ok,{Name} not good not bad, for an amateur...");
               return $"Ok,{Name} not good not bad, for an amateur...";
               break;

               // Console.WriteLine($"{Name} is a masterpeace!!! I want to {Country} to take a look at those places!!!");
               return $"{Name} is a masterpeace!!! I want to {Country} to take a look at those places!!!";

               default:

               // Console.WriteLine("HI-hi-hi im not watched this film");
               return "HI-hi-hi im not watched this film";
           }
        }

        public string SendFilm(string toWho)
        {
            return $"Hi {toWho}, can you check {Name}({ProdYear}) to watch? I want to know your opinion about this film))";
        }

        public override string ToString()
        {
            return $"Name:{Name}, Production year:{ProdYear}, Country:{Country}";
        }
    }
}