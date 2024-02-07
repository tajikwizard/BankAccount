using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHoderName { get; set; }
        public double AccountBalance { get; set; }

        public void Deposit (double amount)
        {
            AccountBalance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance : {AccountBalance}");
        }

        public void Withdraw(double amount)
        {

            if(AccountBalance >= amount)
            {
                AccountBalance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {AccountBalance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }


        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHoderName}");
            Console.WriteLine($"Balance: {AccountBalance:C}");
        }
    }
}
