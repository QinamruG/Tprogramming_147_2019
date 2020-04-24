public interface IResultOfMentalWork
{
    string Name { get; set; }

    string Country { get; set; }

    int ProdYear { get; set; }

    string Mark(int mark);

    string Send(string toWho);
}