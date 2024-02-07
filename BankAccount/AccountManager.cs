using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class AccountManager
    {
        private List<Account> accounts = new List<Account>();
        private int nextAccountNumber = 1;

        public void CreateAccount(string accountHolderName, double initialBalance)
        {
            Account newAccount = new Account
            {
                AccountNumber = nextAccountNumber++,
                AccountHoderName = accountHolderName,
                AccountBalance = initialBalance
            };

            accounts.Add(newAccount);
            Console.WriteLine("Account Creaed successfully!");
        }


        public Account FindAccount(int accountNumber)
        {
            return accounts.Find(person => person.AccountNumber == accountNumber);
        }
    }
}
