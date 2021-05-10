using System;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool complete = true;
            Console.WriteLine("-----Welcome to Digital Experion Bank-----");
            Console.WriteLine("1. Create an Account.");
            Console.WriteLine("2. Already have an account.");
            Console.WriteLine("Enter your choice from 1 or 2.");
            int choice = Convert.ToInt32(Console.ReadLine());
            CurrentAccount ca = new CurrentAccount();
            SavingsAccount sa = new SavingsAccount();
            ReccuringAccount ra = new ReccuringAccount();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Account created...");
                    break;
                case 2:
                    Console.WriteLine("Which type of account you want to choose?");
                    Console.WriteLine("1. Savings Account.");
                    Console.WriteLine("2. Current Account.");
                    Console.WriteLine("3. Reccuring Deposit Account.");
                    Console.WriteLine("Enter your choice.");
                    int accChoice = Convert.ToInt32(Console.ReadLine());
                    while (complete)
                    {
                        switch (accChoice)
                        {
                            case 1:
                                Console.WriteLine("\n \n Welcome to your savings account.....");
                                Console.WriteLine("Choose from the below operations to perform.");
                                Console.WriteLine("1.Deposit.");
                                Console.WriteLine("2.Withdraw.");
                                Console.WriteLine("3.Check Balance");
                                Console.WriteLine("4.Exit");
                                Console.WriteLine("Enter your choice from 1,2 ,3 or 4.");
                                int op_choice1 = Convert.ToInt32(Console.ReadLine());
                                switch (op_choice1)
                                {
                                    case 1:

                                        sa.deposit();
                                        break;

                                    case 2:
                                        sa.Withdraw();
                                        break;

                                    case 3:
                                        sa.getBalance();
                                        break;
                                    case 4:
                                        complete = false;
                                        break;

                                }


                                break;

                            case 2:
                                Console.WriteLine("\n \n Welcome to your current account....");
                                Console.WriteLine("Choose from the below operations to perform.");
                                Console.WriteLine("1.Deposit.");
                                Console.WriteLine("2.Withdraw.");
                                Console.WriteLine("3.Check Balance");
                                Console.WriteLine("4.Exit");
                                Console.WriteLine("Enter your choice from 1,2,3 or 4.");
                                int op_choice2 = Convert.ToInt32(Console.ReadLine());
                                switch (op_choice2)
                                {
                                    case 1:

                                        ca.deposit();
                                        break;

                                    case 2:
                                        ca.Withdraw();
                                        break;

                                    case 3:
                                        ca.getBalance();
                                        break;
                                    case 4:
                                        complete = false;
                                        break;

                                }


                                break;

                            case 3:
                                Console.WriteLine("\n \n Welcome to your Reccuring deposit account....");
                                Console.WriteLine("Choose from the below operations to perform.");
                                Console.WriteLine("1.Deposit.");
                                Console.WriteLine("2.Withdraw.");
                                Console.WriteLine("3.Check Balance");
                                Console.WriteLine("4.Exit");
                                Console.WriteLine("Enter your choice from 1,2,3 or 4.");
                                int op_choice3 = Convert.ToInt32(Console.ReadLine());
                                switch (op_choice3)
                                {
                                    case 1:

                                        ra.deposit();
                                        break;

                                    case 2:
                                        ra.Withdraw();
                                        break;

                                    case 3:
                                        ra.getBalance();
                                        break;
                                    case 4:
                                        complete = false;
                                        break;

                                }


                                break;


                        }

                    }

                    break;
            }
        }
    }
}
