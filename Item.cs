using System; //  behövs för console.writeline
using System.Collections.Generic; // nödvändig för att skriva List

namespace MyTradingApp
{
  public class Item
  {
    public string name;
    public int price;
  }

  class Program
  {
    static void Main() // Metoden ska inte returnera ett värde utan bara kör det som är under
    {
      List<Item> items = new List<Item>(); // Vill skapa en lista med items och värde 

      items.Add(new Item() { name = "sofa", price = 1000 });
      items.Add(new Item() { name = "chair", price = 200 });
      items.Add(new Item() { name = "lamp", price = 400 });
      items.Add(new Item() { name = "clock", price = 700 });
      items.Add(new Item() { name = "table", price = 1200 });

      foreach (var item in items) // Ska skriva ut allt ovanför 
      {
        Console.WriteLine("Name: " + item.name + ", Price: " + item.price); // skriver ut pris och namn på varan
      }

    }

  }

}