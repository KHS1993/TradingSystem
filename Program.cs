//En användare ska kunna registrera ett konto
//En användare ska kunna logga ut 
//En användare ska kunna logga in
//En användare ska kunna ladda upp information om varan de vill byta
//En användare ska kunna bläddra i en lista som visar andra användares varor
//En användare ska kunna begära ett byta av andra användares varor
//En användare ska kunna bläddra bland genomförda begäran
// glöm ej assert


using App;


List<IUser> users = new List<IUser>();
users.Add(new User("Kifle", "123"));
users.Add(new User("Shahrooz", "123"));
users.Add(new User("Nedem", "123"));
users.Add(new User("Rami", "123"));
users.Add(new User("Simon", "123"));


IUser? active_user = null; // Skapar en variabel som kan innehålla en användare även om det saknas nu. 

bool running = true; // Vill att programmet ska fråga om lösenord tills användaren skriver rätt.
while (running) // uppreppa koden till running blir falskt. 
{
  if (active_user == null) // Kollar om någon är inloggad annars måste de logga in och då ber koden undertill de att logga in.
    Console.Clear(); // Rensar allt. 

  Console.WriteLine("username");
  string username = Console.ReadLine();

  Console.Clear();

  Console.WriteLine("password");
  string password = Console.ReadLine();

  Console.Clear();

  foreach (IUser user in users) // Går igenom alla användare som jag har skrivit in däruppe. 
  {
    if (user.TryLogin(username, password)) // Kollar varje användares username och password passar. Returnerar sen true eller false om inloggningen är korrekt.
    {
      active_user = user; // Om ovanstående stämmer så blir användaren inloggad. Aktiv användare.
      break;
    }
  }
}
else
{

  Console.Clear();
  Console.WriteLine(" --- Trading System --- ");

  switch (active_user.GetRole())
{


  case Role.User:
      break;

    case Role.Guest:
      break;

  bool UserRunning = true;
      while (UserRunning)

      {
        Console.WriteLine("Welcome Trader");
        Console.WriteLine("----------------");
        Console.WriteLine("1. Show my Trades");
        Console.WriteLine("2. Show my Items");
        Console.WriteLine("3. Logout");

      }

      

















