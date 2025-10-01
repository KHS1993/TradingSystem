// email and password

using System;
namespace MyTradingApp
{
  interface IUser // Alla som vill vara användare måste kunna logga in, ha en roll och kunna skapa en ny användare. Kopplat till Program.cs 
  {
    bool TryLogin(string username, string password); // Tar användare och lösenord och kollar om det är sant eller falskt gällande inloggningen

    public Role GetRole(); // returnerar användarens roll 

    string NewUser(); // ska ge tillbaka text och alla i programmet (public) kan ta del av de.
    bool IsRole(Role user);
  }

  public enum Role // iställer för att skriva 0,1,2 så skapas en list med namngivna värden - de olika rollerna under.
  {
    None,
    User,
    Guest,


  }

  public class Trader : IUser // Samma sak här vill att Trader klassen ska följa dessa "instruktioner" i program.cs
  {
    public string Email;
    private string _password; // Lösenord private.
    public Trader(string email)
    {
      Email = email;
    }


    public Trader(string email, string password) // Kollar om inmatning av email och lösenrod från användaren stämmer överens 
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

      return Role.User; // ska returnera users för Traders.
    }

    public string NewUser()
    {

      return "ny användare skapad"; // Texten ska visas när användare skapas.
    }
    public bool IsRole(Role role) // Fick felkod i Program.cs
    {

      return GetRole() == role; // Kollar om användare har en roll.
    }

  }

}


