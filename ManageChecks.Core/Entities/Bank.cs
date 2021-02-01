using System;
using System.Collections.Generic;
using System.Text;

namespace ManageChecks.Core.Entities
{
    public class Bank : BaseEntity<int>
    {
        public Bank(int id, string bankName) : base(id)
        {
            BankName = bankName;
        }

        public string BankName { get; private set; }
    }
}
