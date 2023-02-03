using System;

namespace AtmConsole
{
    internal class AtmConsole
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "SUPER ATM";


            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n-----------------Welcome to My ATM App-----------------\n\n");

            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate" +
                 "a physical ATM card, read the card number and validate it.");

            Console.WriteLine("\n\nPress Enter to continue...\n");
            Console.ReadLine();

        }
    }
}
