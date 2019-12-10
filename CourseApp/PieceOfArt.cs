using System;

namespace CourseApp
{
  public abstract class PieceOfArt
  {
    public PieceOfArt(int prodYear, string name, string country)
    {
      Name = name;
      ProdYear = prodYear;
      Country = country;
    }

    public string Name { get; set; }

    public string Country { get; set; }

    public abstract int ProdYear { get; set; }

    public abstract string Watch();

    public abstract string Mark(int mark);

    public abstract string Send(string toWho);

    public new abstract string ToString();
  }
}
