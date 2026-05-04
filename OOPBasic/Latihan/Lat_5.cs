using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_5
    {
        public static void main()
        {
            BankAccount bankAccount = new BankAccount("John Doe", "123456789", 1000);
            bankAccount.displayAccountInfo();
            bankAccount.deposit(500);
            bankAccount.withDraw(200);
            bankAccount.displayAccountInfo();

            SavingAccount savingAccount = new SavingAccount("Jane Doe", "987654321", 2000, 5);
            savingAccount.displayAccountInfo();
            savingAccount.applyInterest();
            savingAccount.displayAccountInfo();

            CheckAccount checkAccount = new CheckAccount("Jack Doe", "555555555", 500, 1000);
            checkAccount.displayAccountInfo();
            checkAccount.withDraw(1200);
            checkAccount.displayAccountInfo();
        }
    }

    class BankAccount
    {
        private string ownerName;
        private string accountNumber;
        protected decimal balance;

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public BankAccount(string ownerName, string accountNumber, decimal initialBalance)
        {
            this.ownerName = ownerName;
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public void deposit(decimal amount)
        {
            try
            {
                if (amount > 0)
                {
                    this.balance += amount;
                }
                else
                {
                    throw new ArgumentException("Amount must be greater than 0");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public virtual bool withDraw(decimal amount)
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
                    throw new InvalidOperationException("Insufficient balance");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void displayAccountInfo()
        {
            Console.WriteLine($"Owner Name: {ownerName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class SavingAccount : BankAccount
    {
        private decimal interestRate;

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public SavingAccount(string ownerName, string accountNumber, decimal initialBalance, decimal interestRate)
            : base(ownerName, accountNumber, initialBalance)
        {
            this.interestRate = interestRate;
        }

        public override bool withDraw(decimal amount)
        {
            try
            {
               decimal calculatedBalance = this.balance - amount;

               if (calculatedBalance >= 100)
                {
                    this.balance = calculatedBalance;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient balance");
                }

                return true;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void applyInterest()
        {
            this.balance += this.balance * interestRate / 100;
        }
    }

    class CheckAccount : BankAccount
    {
        private decimal overdraftLimit;

        public decimal OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        public CheckAccount(string ownerName, string accountNumber, decimal initialBalance, decimal overdraftLimit)
            : base(ownerName, accountNumber, initialBalance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override bool withDraw(decimal amount)
        {
            try
            {
                decimal calculatedBalance = this.balance + this.overdraftLimit;

                if (calculatedBalance >= amount)
                {
                    this.balance -= amount;
                    return true;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient balance");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
