// email and password

namespace App;


interface IUser // Alla som vill vara användare måste kunna logga in, ha en roll och kunna skapa en ny användare. Berättar vad som måsre göras.

{
  public bool TryLogin(string username, string password); // Tar användare och lösenord och kollar om det är sant eller falskt gällande inloggningen

  public Role GetRole(); // returnerar användarens roll 

  public string NewUser(); // ska ge tillbaka text och alla i programmet (public) kan ta del av de.
}

enum Role // iställer för att skriva 0,1,2 så skapas en list med namngivna värden - de olika rollerna under.
{
  None,
  User,
  Guest,


}