using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml;

namespace CleanArchitectureAccountsAPI.Domain.Entities
{
    public class AccountType
    {
        //Specifies a unique Id for the account type
        public int AccountTypeId { get; set; }

        //Specifies a name for the account type
        public string Name { get; set; }
        public AccountType(int accountTypeId, string name)
        {
            AccountTypeId = accountTypeId;
            Name = name;
        }
    }
}
