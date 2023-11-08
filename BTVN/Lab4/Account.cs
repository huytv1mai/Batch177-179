using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.Lab4
{
    public delegate void BalanceChangedEventHandler(decimal newBalance);
    public class Account
    {
       public event BalanceChangedEventHandler BalanceChanged;
        private decimal balance;
        public decimal Balance
        {
            get { return balance; } set
            {
                balance = value;
                OnBalanceChanged(Balance);
            }
        }
        public void OnBalanceChanged(Decimal newBalance)
        {
            BalanceChanged?.Invoke(newBalance);   
        }
    }
    class ExampleBalance
    {
        public void Run()
        {
            Account account = new Account();
            account.BalanceChanged += HandleBalanceChanged;
            account.Balance = 1000;
            account.Balance = 2000;
            
           /* while (true)
            {
                account.Balance = GetDecimal("Please input new balance: ");

            }
            Console.ReadLine();*/
        }

        /*private decimal GetDecimal(string v)
        {
            throw new NotImplementedException();
        }*/

        void HandleBalanceChanged(decimal newBalance)
        {
            Console.WriteLine("Account balance");
        }
    }
}
