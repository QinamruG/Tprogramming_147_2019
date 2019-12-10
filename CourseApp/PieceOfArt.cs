using System;

namespace CourseApp
{
  public abstract class PieceOfArt
  {
    public abstract string Name { get; set; }

    public abstract string Country { get; set; }

    public abstract int ProdYear { get; set; }

    public abstract string Watch();

    public abstract string Mark(int mark);

    public abstract string Send(string toWho);
  }
}
