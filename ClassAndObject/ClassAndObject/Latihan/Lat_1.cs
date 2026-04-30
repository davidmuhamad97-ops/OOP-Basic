using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            BankAccount account = new BankAccount("123456789", "John Doe");
            
            account.Deposit(1000);
            Console.WriteLine("Current Balance: " + account.GetBalance());

            bool success = account.WithDraw(500);
            Console.WriteLine("Withdrawal Successful: " + success);
            Console.WriteLine("Current Balance: " + account.GetBalance());
            
            success = account.WithDraw(600);
            Console.WriteLine("Withdrawal Successful: " + success);

        }
    }

    class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private string ownerName;

        public BankAccount(string accountNumber, string ownerName)
        {
            this.balance = 0;
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
        }

        public void Deposit(decimal amount) 
        {
            this.balance += amount;
        }

        public bool WithDraw(decimal amount)
        {
            try
            {
                if (this.balance > amount)
                {
                    this.balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }

                if (this.balance <= 0)
                {
                    throw new ArgumentException("Amount must be greater than zero.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public decimal GetBalance()
        {
            return this.balance;
        }
    }
}
