using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2025_12_09_OOP
{
    public class PersonalAccount : Account
    {
        private AccountHolder AccountHolder;

        public PersonalAccount(string customerNumber, string accountNumber, string bankCode, AccountHolder accountHolder) :  base (customerNumber, accountNumber, bankCode)
        {
            AccountHolder = accountHolder;
        }

        public AccountHolder GetAccountHolder() => this.AccountHolder;

        public void SetAccountHolder(AccountHolder newAccountHolder) => this.AccountHolder = newAccountHolder;
    }
}
