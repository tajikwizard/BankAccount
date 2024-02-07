using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountManager accountManager = new AccountManager();

            while (true)
            {
                Console.WriteLine("Bank Account Manager Menu");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. View Account Info");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter account holder name: ");
                        string accountHolderName = Console.ReadLine();
                        Console.Write("Enter initial balance: ");
                        double initialBalance = double.Parse(Console.ReadLine());
                        accountManager.CreateAccount(accountHolderName, initialBalance);
                        break;
                    case "2":
                        Console.Write("Enter account number: ");
                        int depositAccountNumber = int.Parse(Console.ReadLine());
                        Account depositAccount = accountManager.FindAccount(depositAccountNumber);
                        if (depositAccount != null)
                        {
                            Console.Write("Enter deposit amount: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            depositAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found!");
                        }
                        break;
                    case "3":
                        Console.Write("Enter account number: ");
                        int withdrawAccountNumber = int.Parse(Console.ReadLine());
                        Account withdrawAccount = accountManager.FindAccount(withdrawAccountNumber);
                        if (withdrawAccount != null)
                        {
                            Console.Write("Enter withdrawal amount: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            withdrawAccount.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found!");
                        }
                        break;
                    case "4":
                        Console.Write("Enter account number: ");
                        int accountInfoAccountNumber = int.Parse(Console.ReadLine());
                        Account accountInfoAccount = accountManager.FindAccount(accountInfoAccountNumber);
                        if (accountInfoAccount != null)
                        {
                            accountInfoAccount.DisplayAccountInfo();
                        }
                        else
                        {
                            Console.WriteLine("Account not found!");
                        }
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
