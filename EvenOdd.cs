using System;
namespace thite
{
    class Program
    {
        static void Main(string [] args)
        {
            int num;
            Console.WriteLine("Find Even and Odd:");
            Console.WriteLine("First Number:");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is Even.");

            }
            else
            {
                Console.WriteLine("Number is Odd.");
            }

        }
    }
}
