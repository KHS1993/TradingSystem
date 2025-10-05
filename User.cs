// email and password
using System;
using System.Collections.Generic;

namespace MyTradingApp
{
  // En vara som användare kan ladda upp
  public class Item

  {
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    public Item(string name, int price, strinf description)
    {

      Name = name;
      Price = price;
      Description = description;

    }
  }

  // Interface för samtliga användare 
  public interface IUser
  {
    bool TryLogin(string email, string password);
    string Email { get; }
    void UploadItem(Item item); // Ska inte returnera något när anvädaren alddar upp.
    List<Item> GetItems();

  }

  //Trader är användaren som ska kunna ladda upp varor
  public class Trader : IUser
  {

    public string Email { get; private set; }
    private string _password;
    private List<Item> _items;

    public Trader(string email, string password)

    {
      Email = email;
      _password = password;
      _items = new List<Item>();

    }

    // Kontrollera inloggning
    public bool TryLogin(string email, string password)
    {
      return Email == email && _password == password;

    }

    // Ladda upp vara
    public void UploadItem(Item item)

    {

      _items.Add(item);
    }


    // Hämta alla varor 
    public List<Item> GetItems()
    {
      return _items;


    }
  }
}

