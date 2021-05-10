using System;

namespace BankManagement
{
    public class ReccuringAccount : IAccount
    {
        private long balance;

        public ReccuringAccount(int bal)
        {
            this.balance = bal;
        }
        public void deposit()
        {
            Console.WriteLine("Enter the amount to deposit.");
            int amount = Convert.ToInt32(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Updated reccuring account balance is : " + balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw.");
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
            Console.WriteLine("Your reccuring account balance is :" + balance);
        }

    }
}