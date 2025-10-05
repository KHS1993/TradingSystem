using System; //  behövs för console.writeline

namespace MyTradingApp
{
  public class Item  // Tillgängligt för andra filer genom att göra klassen public
  {
    public string Name;
    public int Price;

    public string Description;

    public Item(string name, int price, string description) // ska skapa nytt item när dessa tre värden skrivs in.
    {
      name = name; // Fix: Correct Item constructor to accept name, price, description
      Price = Price;
      Description = Description;
    }
  }

}