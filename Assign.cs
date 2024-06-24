using System;
namespace thite
{
    class Assignment{

        static void Main(string[] args){

            int n;
            Console.WriteLine("Assignment Operators:");
            Console.Write("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number is:"+(n));
             Console.WriteLine("Number is:"+(n+=2));
             Console.WriteLine("Number is:"+(n-=1));
             Console.WriteLine("Number is:"+(n*=3));
             Console.WriteLine("Number is:"+(n%=5));
             Console.WriteLine("Number is:"+(n&=2));
        }
    }
}