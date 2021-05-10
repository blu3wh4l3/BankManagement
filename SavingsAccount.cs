using System;

namespace BankManagement
{
    public class SavingsAccount : IAccount
    {
        private int balance;

        public SavingsAccount(int bal)
        {
            this.balance = bal;
        }
        public void deposit()
        {
            Console.WriteLine("Enter the amount to deposit.");
            int amount = Convert.ToInt32(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Updated savings account balance is : " + balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to deposit.");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance in your account!!!!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Successfully withdrawn : " + amount);
            }
        }

        public void getBalance()
        {
            Console.WriteLine("Your savings account balance is :" + balance);
        }

    }
}