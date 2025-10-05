// requesters - Receiver - status - items 

using System;
using System.Collections.Generic;



namespace MyTradingApp
{
  public class TradeHandler // Skapar en klass som ska representera en användare (Trader). 

  {

    public string Email { get; private set; } // Private på båda då endast klassen själv ska kunna ändra för ökad säkerhet. 
    private string _password; // get och set för att värdet ska kunna ändras men endast inifrån klassen.
    private List<Item> _items = new List<Item>();
    public TradeHandler(string email, string password)
    {
      Email = email;
      _password = password;
    }

    public bool TryLogin(string username, string password)
    {
      return username == Email && password == _password;
    }

    public enum Role
    {
      User,
      Guest,
    }
    public Role GetRole()
    {
      return Role.User;
    }

    public string NewUser()
    {
      return $"New user {Email} created";
    }

    public bool IsRole(Role role)
    {
      return GetRole() == role;
    }




    public void UploadItem(string name, int price, string description)
    {
      Item newItem = new Item(name, price, description);
      _items.Add(newItem);
      Console.WriteLine($"item uploaded: {name}");


    }
    public List<Item> GetItems()
    {
      return new List<Item>(_items);

    }

  }
}




