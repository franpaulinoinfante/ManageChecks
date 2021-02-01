using System;
using System.Collections.Generic;
using System.Text;

namespace ManageChecks.Core.Entities
{
    public class BankAccountType: BaseEntity<int>
    {
        public BankAccountType(int id, string typeOfAccount) : base(id)
        {
            TypeOfAccount = typeOfAccount;
        }

        public string TypeOfAccount { get; private set; }
    }
}
