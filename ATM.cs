using System;

namespace thite
{
    class Atm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------Welcome To ATM Service---------------------------------");

            int balance = 1000;
              Console.WriteLine("Enter YOUR PIN ::");
            int pin = Convert.ToInt32(Console.ReadLine());

            while (true)
            {

                Console.WriteLine("\n1. Check Balance\n2. Cash Deposit\n3. Cash Withdraw\n4. Quit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your Balance is: Rs " + balance);
                        break;

                    case 2:
                        Console.Write("Enter the deposit amount: Rs ");
                        balance += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deposit successful and Your Available balance is: Rs " + balance);
                        break;

                    case 3:
                        Console.Write("Enter the withdrawal amount: Rs ");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        balance -= withdrawAmount;
                        Console.WriteLine("Withdrawal successful. Your new balance is: Rs " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using our service.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
