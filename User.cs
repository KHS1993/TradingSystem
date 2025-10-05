
using System.Collections.Generic;

namespace MyTradingApp
{
  // Interface för alla användare
  public interface IUser // Ska definera vad användarklasser måste kunna göra, logga in , lagra e-post ,ladde upp varor och hämta de.
  {
    bool TryLogin(string email, string password);
    string Email { get; }
    void UploadItem(Item item);
    List<Item> GetItems();
  }

  // Representerar en användare som ska hantera varor.
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

    public bool TryLogin(string email, string password)
    {
      return Email == email && _password == password;
    }

    public void UploadItem(Item item) // Lägger till item i användarens lista.
    {
      _items.Add(item);
    }

    public List<Item> GetItems() // returnerar de varor som användaren har laddat upp
    {
      return _items;
    }
  }
}

// Klassen ska hantera användarinloggning och varuhantering för Trader-användaren.