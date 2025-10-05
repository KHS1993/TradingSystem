using System; //  behövs för console.writeline

namespace MyTradingApp
{
  // klass som reprsenterar en vara
  public class Item  // Tillgängligt för andra filer genom att göra klassen public
  {
    public string Name { get; set; }
    public int Price { get; set; }

    public string Description { get; set; }

    //Konstruktor för att sapa en ny Item
    public Item(string name, int price, string description) // ska skapa nytt item när dessa tre värden skrivs in.
    {
      name = name;
      Price = Price;
      Description = Description;
    }

    // skriver ut info om varan
    public void PrintInfo()
    {
      Console.WriteLine($"Name: {Name}, Price: {Price}, Description{Description}");
    }
  }

}