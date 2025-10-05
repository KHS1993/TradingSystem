// requesters - Receiver - status - items 

using System;

namespace MyTradingApp
{
  public class Trader : IUser // Skapar en klass som ska representera en användare (Trader). 

  {

    public string Email { get; private set; } // Private på båda då endast klassen själv ska kunna ändra för ökad säkerhet. 
    private string _password; // get och set för att värdet ska kunna ändras men endast inifrån klassen.

    public Trader(string email, string password)
    {
      Email = email;
      _password = password;
    }

    public bool TryLogin(string username, string password)
    {
      return username == Email && password == _password;
    }

    public Role GetRole()
    {
      return Role.User;
    }

    public string NewUser()
    {
      return "New user created";
    }

    public bool IsRole(Role role)
    {
      return GetRole() == role;
    }
  }

}


