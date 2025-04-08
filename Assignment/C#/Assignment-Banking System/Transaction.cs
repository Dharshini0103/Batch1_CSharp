using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Banking_System
{
    internal class Transaction
    {
        
            public long AccountNumber { get; set; }
            public string Description { get; set; }
            public DateTime DateTime { get; set; }
            public string TransactionType { get; set; }
            public float TransactionAmount { get; set; }
        

    }
}
