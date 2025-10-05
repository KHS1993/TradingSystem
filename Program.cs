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

namespace MyTradingApp

{

  class Program
  {

    static void Main()

    {

      List<IUser> users = new List<IUser>();

      {

        new Trader("Kifle", "123");
        new Trader("Shahrooz", "123");
        new Trader("Nedem", "123");
        new Trader("Rami", "123");
        new Trader("Simon", "123");

      }
      ;

      IUser? active_user = null; // Skapar en variabel som kan innehålla en användare även om det saknas nu. 
      bool running = true; // Vill att programmet ska fråga om lösenord tills användaren skriver rätt.


      while (running) // uppreppa koden till running blir falskt. 
      {
        // Kollar om någon är inloggad annars måste de logga in och då ber koden undertill de att logga in.
        Console.Clear(); // Rensar allt. 
        Console.WriteLine("username");
        string username = Console.ReadLine();


        Console.WriteLine("password");
        string password = Console.ReadLine();



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
        Console.Clear();
        Console.WriteLine("Welcome Trader");
        Console.WriteLine("----------------");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Logout");

        string Input = Console.ReadLine();

        switch (Input)
        {

          case "1": // LOGGA IN
            Console.WriteLine("Choose username");
            string newUsername = Console.ReadLine();


            Console.WriteLine("Choose password");
            string newPassword = Console.ReadLine();




            bool exists = false; // Talar om att användarnamnet redan existerar.
            foreach (IUser user in users) // Går igenom redan registrerade användare 

            {
              if (user.Email == newUsername) // Fix: Use correct property for checking existing usernames
              {

                exists = true;
                Console.WriteLine("User already exists");
                break;

              }
            }
            if (!exists) // Kör koden när när användare inte existerar
            {
              users.Add(new Trader(newUsername, newPassword)); //  Ny användare skapas efter input av namn och lösenord från användaren. add-funktionen sparar användaren i listan av användare. 
              Console.WriteLine("User registered successfully");
            }
            break;

          case "2":
            active_user = null;
            UserRunning = false;
            break;


          default:
            Console.WriteLine("Invalid option"); // Skriver ut detta om användaren skriver något som ej matcher case i switch satsen.
            break;

        }

        Console.WriteLine("Press Enter to continue"); // Användaren ska kunna se meddelandet innan nästa meny visas.
        Console.ReadLine();

      }

    }

  }

}