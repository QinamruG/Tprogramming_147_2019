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
    }
}
