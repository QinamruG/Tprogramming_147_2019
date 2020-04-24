using System;

namespace CourseApp
{
    public abstract class PieceOfArt : IComparable<PieceOfArt>, IResultOfMentalWork
    {
        public PieceOfArt(int prodYear, string name, string country)
        {
            Name = name;
            ProdYear = prodYear;
            Country = country;
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public virtual int ProdYear { get; set; }

        public abstract string Watch();

        public abstract string Mark(int mark);

        public abstract string Send(string toWho);

        public new abstract string ToString();

        public virtual string VirtualView()
        {
            return "Virtual Method";
        }

        public int CompareTo(PieceOfArt obj)
        {
            PieceOfArt poa = obj;
            if (poa != null)
            {
                return this.Name.CompareTo(poa.Name);
            }
            else
            {
                throw new ArgumentException("object not found");
            }
        }
    }
}
