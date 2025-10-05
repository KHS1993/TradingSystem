
using System.Collections.Generic;

namespace MyTradingApp
{
  // Interface för alla användare
  public interface IUser
  {
    bool TryLogin(string email, string password);
    string Email { get; }
    void UploadItem(Item item);
    List<Item> GetItems();
  }

  // Trader är en användare som kan ladda upp varor
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

    public void UploadItem(Item item)
    {
      _items.Add(item);
    }

    public List<Item> GetItems()
    {
      return _items;
    }
  }
}
