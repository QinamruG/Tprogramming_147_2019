using System;

namespace CourseApp
{
    public class Film
    {
        private int age;
        string country;

        public Film()
        : this(0, "Untitled","No country")
        {
        }

        public Film(int age, string name,string country)
        {
            Name = name;
            Age = age;            
        }

        public string Name { get; set; }
        public string Country; 

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 1910 && value < 2020)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 1910 and < than 2020");
                }
            }

        }
        public void WatchFilm()
        {
          Console.WriteLine("I watch film:");
          Age=1990;
          


        }
    }
}