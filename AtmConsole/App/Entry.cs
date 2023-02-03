using AtmConsole.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsole.App
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            AtmConsole atm = new AtmConsole();
            atm.InitializeData();
            atm.CheckUserCardNumAndPassword();
        }
    }
}

