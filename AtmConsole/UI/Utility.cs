using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsole.UI
{
    public static class Utility
    {
        public static void PressEnterToContinue(){
            Console.WriteLine("\n\nPress Enter to continue...\n");
            Console.ReadLine();
        }

        public static string GetUserInput()
        {
            Console.WriteLine("Enter you Card Number");
            return Console.ReadLine();
        }

        public static string GetUserCardPin()
        {
            Console.WriteLine("Enter you Card PIN");
            return Console.ReadLine();
        }



    }
}

