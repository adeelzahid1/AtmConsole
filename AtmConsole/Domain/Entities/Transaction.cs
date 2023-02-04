﻿using AtmConsole.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsole.Domain.Entities
{
    internal class Transaction
    {
        public long TransactionId { get; set; }
        public long UserBankAccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Descriprion { get; set; }
        public Decimal TransactionAmount { get; set; }
    }
}
