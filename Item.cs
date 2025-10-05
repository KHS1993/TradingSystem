using System;

namespace MyTradingApp
{
  // En vara som användare kan ladda upp
  public class Item
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    public Item(string name, int price, string description)
    {
      Name = name;
      Price = price;
      Description = description;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Name: {Name}, Price: {Price}, Description: {Description}");
    }
  }
}
