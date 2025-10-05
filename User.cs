// email and password


namespace MyTradingApp
{
  public interface IUser // Alla som vill vara användare måste kunna logga in, ha en roll och kunna skapa en ny användare. Kopplat till Program.cs 
  {
    bool TryLogin(string username, string password); // Tar användare och lösenord och kollar om det är sant eller falskt gällande inloggningen
    Role GetRole();
    string NewUser();
    bool IsRole(Role role);
    string Email { get; }
  }


  public enum Role // iställer för att skriva 0,1,2 så skapas en list med namngivna värden - de olika rollerna under.
  {
    None,
    User,
    Guest,


  }
}


