using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsole.Domain.Entities.Enums
{
    public  enum AppMenu
    {
        CheckBalance = 1,
        PlaceDeposit,
        MakeWithdrawal,
        InternalTransfer,
        ViewTransaction,
        Logout
    }
}
