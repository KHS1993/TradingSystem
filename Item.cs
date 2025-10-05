using System;

namespace MyTradingApp
{
  // En vara som användare kan ladda upp
  public class Item // Skapar en klass som ska representera en vara
  {
    // Ska lagra namn, pris och beskrivning av varan.
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    // Konstrultor som skapar nytt Item med angivna värden.
    public Item(string name, int price, string description)
    {
      Name = name;
      Price = price;
      Description = description;
    }

    public void PrintInfo() // Skriver ut info om caran till konsolen.
    {
      Console.WriteLine($"Name: {Name}, Price: {Price}, Description: {Description}");
    }
  }
}

// klassen ska användas för att skapa, lagra och visa info om varor.