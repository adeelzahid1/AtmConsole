using AtmConsole.Domain.Entities;
using AtmConsole.UI;
using System;
using System.Collections.Generic;

namespace AtmConsole.App
{
    public class AtmConsole
    {
        private List<UserAccount> userAccountList;
        private UserAccount userAccount;

        public void InitializeData() {
            userAccountList = new List<UserAccount>
           {
              new UserAccount{Id=1, FullName = "Adeel Zahid", AccountNumber=123456,CardNumber =321321, CardPin=123123,AccountBalance=50000.00m,IsLocked=false},
                new UserAccount{Id=2, FullName = "Mohsin Nazir", AccountNumber=456789,CardNumber =654654, CardPin=456456,AccountBalance=4000.00m,IsLocked=false},
                new UserAccount{Id=3, FullName = "Mudssar Hussain", AccountNumber=123555,CardNumber =987987, CardPin=789789,AccountBalance=2000.00m,IsLocked=true},
           };
        }

        public void CheckUserCardNumAndPassword()
        {

            UserAccount inputAccount =  AppScreen.UserLoginForm();
            Console.WriteLine($"{inputAccount.CardNumber} : {inputAccount.CardPin}");

        }

    }
}
