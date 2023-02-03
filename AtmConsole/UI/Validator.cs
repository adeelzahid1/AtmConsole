using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsole.UI
{
    public static class Validator
    {
        public static T Convert<T>(string prompt)
        {
            bool isValid = false;
            string userInput;

            while (!isValid) {
                userInput = Utility.GetUserInput(prompt);
               
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch (Exception)
                {
                    Utility.PrintMessage("Invalid input . Try Again", false);                    
                }
            }
            return default;

        }
        

    }
}
