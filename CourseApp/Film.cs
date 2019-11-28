using System;

namespace CourseApp
{
    public class Film
    {
        private int year;

        public Film()
        : this(0, "Untitled", "No country")
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
                    Console.WriteLine($"Production year should be > 1888 and < than {DateTime.Now.Year}");
                }
            }
        }

        public string WatchFilm()
        {
        return $"This is a film, named {Name}, Which came out in {ProdYear} in {Country}, was awesome!";
        }

        public void MarkFilm(int mark)
        {
           switch (mark)
           {
               case 1:

               Console.WriteLine($"{Name} is terrible film, dont watch it never!!!!!! ");
               break;

               case 2:

               Console.WriteLine($"Ok,{Name} not good not bad, for an amateur...");
               break;

               case 3:

               Console.WriteLine($"{Name} is a masterpeace!!! I want to {Country} to take a look at those places!!!");
               break;

               default:

               Console.WriteLine("HI-hi-hi im not watched this film");
               break;
           }
        }

        public string SendFilm(string toWho)
        {
          return $"Hi {toWho}, can you check {Name}({ProdYear}) to watch? I want to know your opinion about this film))";
        }
    }
}
