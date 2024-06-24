using System;
class Hello{
    public static void Main(string[] args)
    {
        Console.WriteLine("**WELCOME TO ATM SERVICE ******");
        Console.WriteLine("Enter YOUR PIN ::");
        int pin = Convert.ToInt32(Console.ReadLine());
        int choice;
        if(pin != 0){
            Console.WriteLine("1= Check Balance ::");
            Console.WriteLine("2= Cash Deposit ::");
            Console.WriteLine("3=Cash Withdraw::");
            Console.WriteLine("4=Exit or Quit::");
            Console.WriteLine("Enter Choice To perform Transaction ::");
            choice=Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("***************** WELCOME TO ATM SERVICE: CHECK YOUR BA;ANCE *******************");
                     Console.WriteLine("Your Balance is : Rs 1000/~");
                     Console.WriteLine("Thank You....! Visit Again !! ");
                     break;
                case 2:
                    Console.WriteLine("CASH DEPOSIT");
                    break;
                case 3:
                    Console.WriteLine("CASH WITHDRAW");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("PLEASE ENTER VALID CHOICE FOR TRANSACTION");
                    break;    
            }


        }
        else{
            Console.WriteLine("PLEASE ENTER A VALID PIN....");
        }
        }
}