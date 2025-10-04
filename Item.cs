using System; //  behövs för console.writeline
using System.Collections.Generic; // nödvändig för att skriva List

namespace MyTradingApp
{
  public class Item  // Tillgängligt för andra filer genom att göra klassen public
  {
    public string name;
    public int price;

    public string description;

    public item(string name, int price, string description) // ska skapa nytt item när dessa tre värden skrivs in.
    {
      Name = itemName;
      price = itemPrice;
      description = itemDescription;

    }
  }

  class Program // klassmetoden innehåller startmetoden Main, C# letar efter Main metoden för att köra programmet och det måste alltid ligga i en klass. 
  {
    static void Main() // Metoden ska inte returnera ett värde utan bara kör det som är under
    {
      List<Item> items = new List<Item>(); // Vill skapa en lista med items och värde 

      items.Add(new Item() { name = "sofa", price = 1000 }); // skapar en ny item med namn och pris
      items.Add(new Item() { name = "chair", price = 200 });
      items.Add(new Item() { name = "lamp", price = 400 });
      items.Add(new Item() { name = "clock", price = 750 });
      items.Add(new Item() { name = "table", price = 1200 });

      foreach (var item in items) // Ska skriva ut allt ovanför 
      {
        Console.WriteLine("Name: " + item.name + ", Price: " + item.price); // skriver ut pris och namn på varan
      }

    }

  }

}