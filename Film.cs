using System;

namespace CourseApp
{
    public class Film
    {
        private int age;
        string country;

        public Film()
        : this(0, "Untitled","No country", true)
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
                if (value >= 0 && value < 20)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 0 and < than 20");
                }
            }
        }
    }
}