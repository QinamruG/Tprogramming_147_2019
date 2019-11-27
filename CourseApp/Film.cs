using System;

namespace CourseApp
{
    public class Film
    {
        private int age;
        /*private string country;
        private string name;*/

        public Film()
        : this(0, "Untitled", "No country")
        {
        }

        public Film(int age, string name, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 1888 && value < 2020)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 1888 and < than 2020");

                    // throw new Exception[];
                }
            }
        }

        public void WatchFilm()
        {
        Console.WriteLine($"This is a film, named {Name}, Which came out in {Age} in {Country}, was awesome!");
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
        public string SendFilm(string ToWho)
        {
          return $"Hi {ToWho}, can you check {Name}({Age}) to watch? I want to know your opinion about this film))";
        }
    }
}
