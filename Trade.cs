// requesters - Receiver - status - items 

using System;
using System.Collections.Generic;



namespace MyTradingApp // Vill samla alla relaterande klasser under samma namn för att unvika namnkonflikter
{
  public class TradeHandler // Skapar en klass som ska representera en användare (Trader). 

  {

    public string Email { get; private set; } // Private på båda då endast klassen själv ska kunna ändra för ökad säkerhet. Sparar användarens email.
    private string _password; // get och set för att värdet ska kunna ändras men endast inifrån klassen.
    private List<Item> _items = new List<Item>(); // Lista på varor som användaren har laddat upp
    public TradeHandler(string email, string password) // Konstruktor som skapar user med användare email och lösen.
    {
      Email = email;
      _password = password;
    }

    public bool TryLogin(string username, string password) // Ska kontrollera om email och lösenord matchar inloggningen.
    {
      return username == Email && password == _password;
    }

    public enum Role // ska definera användarens roll.
    {
      User,
      Guest,
    }
    public Role GetRole() // Returnerar användares roll, i detta fall user.
    {
      return Role.User;
    }

    public string NewUser() // Skapar ett meddelande när en ny användare registreras.
    {
      return $"New user {Email} created";
    }

    public bool IsRole(Role role) // Kontrollerar att användaren har en viss roll.
    {
      return GetRole() == role;
    }


    public void UploadItem(string name, int price, string description) // Användaren ska kunna lägga till en ny vara i sin lista. Skapar nytt objekt i item-objekt pch lägger till det i _items.
    {
      Item newItem = new Item(name, price, description);
      _items.Add(newItem);
      Console.WriteLine($"item uploaded: {name}");


    }
    public List<Item> GetItems() // Returnerar en lista med användarens varor.
    {
      return new List<Item>(_items);

    }

  }
}




