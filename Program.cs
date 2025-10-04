//En användare ska kunna registrera ett konto
//En användare ska kunna logga ut 
//En användare ska kunna logga in
//En användare ska kunna ladda upp information om varan de vill byta
//En användare ska kunna bläddra i en lista som visar andra användares varor
//En användare ska kunna begära ett byta av andra användares varor
//En användare ska kunna bläddra bland genomförda begäran
// glöm ej assert


using System;
using System.Collections.Generic;
using MyTradingApp;


List<IUser> users = new List<IUser>();

users.Add(new Trader("Kifle", "123"));
users.Add(new Trader("Shahrooz", "123"));
users.Add(new Trader("Nedem", "123"));
users.Add(new Trader("Rami", "123"));
users.Add(new Trader("Simon", "123"));






IUser? active_user = null; // Skapar en variabel som kan innehålla en användare även om det saknas nu. 

bool running = true; // Vill att programmet ska fråga om lösenord tills användaren skriver rätt.
while (running) // uppreppa koden till running blir falskt. 
{
  // Kollar om någon är inloggad annars måste de logga in och då ber koden undertill de att logga in.
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
      running = false; // Loopen ska stoppas när användare logga in korrekt.
      break;
    }
  }
}

// --- Meny ---


  bool UserRunning = true; // skriver ut menyn i en oändlig loop tills någon loggar ut
  while (UserRunning)

  {
    Console.WriteLine("Welcome Trader");
    Console.WriteLine("----------------");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Show my Trades");
    Console.WriteLine("4. Show my Items");
    Console.WriteLine("5. Logout");

    string Input = Console.ReadLine();

    switch (Input)
    {

      case "1": // LOGGA IN
        Console.WriteLine("Enter username");
        string username = Console.ReadLine();


        Console.WriteLine("Enter password");
        string password = Console.ReadLine();
        break;

      case "2": // REGISTRERA KONTO
        Console.WriteLine("Choose username");
        string newUsername = Console.ReadLine();
        break;


        bool exists = false; // Talar om att användarnamnet redan existerar.
        foreach (IUser user in users) // Går igenom redan registrerade användare 

        {
          if (User.Username == newUsername)
          {

            exists = true;
            Console.WriteLine("User already exists");
            break;

          }
        }
        if (!exists) // Kör koden när när användare inte existerar
        {
          users.Add(new user(newUsername, newPassword));
          Console.WriteLine("Username added");
        }
        break;

      case "3":

      case "4":

      case "5":
        active_user = null;
        UserRunning = false;
        break;

    }

    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();

  }