using AtmConsole.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsole.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "SUPER ATM";


            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n-----------------Welcome to My ATM App-----------------\n\n");

            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate" +
                 "a physical ATM card, read the card number and validate it.");

            Utility.PressEnterToContinue();
        }


        internal static void UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();
            tempUserAccount.CardNumber = Validator.Convert();
        }

    }
}


