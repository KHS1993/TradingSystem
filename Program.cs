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

class Program
{
  static void Main()
  {
    List<IUser> users = new List<IUser>();
    IUser? activeUser = null;
    bool running = true;

    while (running)
    {
      Console.Clear();

      if (activeUser == null)
      {
        Console.WriteLine("--- Welcome ---");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine() ?? "";

        switch (choice)
        {
          case "1":
            Console.Write("Enter email: ");
            string email = Console.ReadLine() ?? "";
            Console.Write("Enter password: ");
            string password = Console.ReadLine() ?? "";

            if (users.Exists(u => u.Email == email))
            {
              Console.WriteLine("User already exists!");
            }
            else
            {
              users.Add(new Trader(email, password));
              Console.WriteLine("User registered successfully");
            }

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            break;

          case "2":
            Console.Write("Email: ");
            string loginEmail = Console.ReadLine() ?? "";
            Console.Write("Password: ");
            string loginPassword = Console.ReadLine() ?? "";

            activeUser = null;
            foreach (IUser u in users)
            {
              if (u.TryLogin(loginEmail, loginPassword))
              {
                activeUser = u;
                break;
              }
            }

            if (activeUser != null)
            {
              Console.WriteLine("Login successful");
            }
            else
            {
              Console.WriteLine("Invalid email or password!");
            }

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            break;

          case "3":
            running = false;
            break;

          default:
            Console.WriteLine("Invalid input, press Enter to continue");
            Console.ReadLine();
            break;
        }
      }
      else
      {
        Console.Clear();
        Console.WriteLine("--- Welcome ---");
        Console.WriteLine("1. Upload Item");
        Console.WriteLine("2. Show My Items");
        Console.WriteLine("3. Show All Items");
        Console.WriteLine("4. Logout");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine() ?? "";

        switch (choice)
        {
          case "1":
            Console.Write("Item name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Price: ");
            string priceInput = Console.ReadLine() ?? "0";
            int price = int.TryParse(priceInput, out int p) ? p : 0;
            Console.Write("Description: ");
            string desc = Console.ReadLine() ?? "";

            activeUser.UploadItem(new Item(name, price, desc));
            Console.WriteLine("Item uploaded!");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            break;

          case "2":
            Console.WriteLine("--- My Items ---");
            foreach (Item item in activeUser.GetItems())
            {
              Console.WriteLine($"{item.Name} - {item.Price} - {item.Description}");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            break;

          case "3":
            Console.WriteLine("--- All Users Items ---");
            foreach (IUser user in users)
            {
              if (user != activeUser)
              {
                foreach (Item item in user.GetItems())
                {
                  Console.WriteLine($"{item.Name} - {item.Price} - {item.Description} (Owner: {user.Email})");
                }
              }
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            break;

          case "4":
            activeUser = null;
            break;

          default:
            Console.WriteLine("Invalid input, press Enter to continue");
            Console.ReadLine();
            break;
        }
      }
    }
  }
}
