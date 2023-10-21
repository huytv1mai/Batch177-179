using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
    //1. Initial delegate
    public delegate void BalanceChangedEventHandler(decimal newBalance);
    public class Account
    {
        //Declare event
        public event BalanceChangedEventHandler BalanceChanged;
        /*public decimal Balance { get; set; }*/
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                OnBalanceChanged(balance);
            }
        }
        public void OnBalanceChanged(decimal newBalance)
        {
            BalanceChanged?.Invoke(newBalance);
        }
    }

    class ExampleBalance
    {
        public void Run()
        {
            Account account = new Account();
            // Simulate a transaction by updating the account balance
            //Register event
            account.BalanceChanged += HandleBalanceChanged;
            //Raise event
            while (true)
            {
                account.Balance = GetDecimal("Please input new balance: ");
            }
            Console.ReadLine();
        }

        void HandleBalanceChanged(decimal newBalance)
        {
            Console.WriteLine("Account balance has changed. New balance: " + newBalance);
            // Perform any additional actions related to the balance change here
        }

        decimal GetDecimal(string msg)
        {
            Console.WriteLine(msg);
            return Convert.ToDecimal(Console.ReadLine());
        }
    }
}
