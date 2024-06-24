using System;
namespace thite{
    class Fact{
        static void Main(string[] args){

            int num,factorial=1;
            Console.WriteLine("Factorial.");
            Console.WriteLine("Enter the number to find the factorial:");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
        {
            factorial=factorial*i;
        }
        Console.WriteLine("Factorial is: "+factorial);
    }
}
}