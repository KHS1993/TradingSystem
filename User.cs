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
      Email = email; // Sätter användarens email ( lagrar det i objekt )
      _password = password; // sparar lösenord i objekt. (Glöm ej understreck i början är för att markera det är en privat variabel)
    }

    public bool TryLogin(string username, string password) // Ska testa om användarens input av användarnamn och lösenord stämmer.
    {

      return username == Email && password == _password; // Användarens input ska stämma överens med det som finns sparat. 
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
  

    class User // Skapade en klass för användare.
    {
      List<Item> items = new List<Item>(); // Lägger den i klassen och inte i metoden då jag inte vill att den ska skapas varje gång metoden körs.
       // Sparas så länge användaren finns kvar.
      public void UploadItem(string name, int price, string description) // användaren ska kunna ladda upp en vara
      {

        Item newItem = new Item(name, price, description); // Skapar ett nytt objek med item utifrån användarens input.
        items.Add(newItem); // Lägger till item i användarens lista(items). Sparar varan och användaren ska kunna ladda upp fler.

        Console.WriteLine("Item uploaded: " + name); // Meddelar användaren att varan är uppladad.


      }

    }

  }

}


