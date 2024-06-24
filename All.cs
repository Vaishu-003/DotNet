using System;
namespace thite
{
    class Program
    {
        static void Main(string [] args)
        {
            int num1,num2;
            Console.WriteLine("Division:");
            Console.Write("First Number:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number:");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition is:"+(num1+num2));
            Console.WriteLine("Substration is:"+(num1-num2));
            Console.WriteLine("Multiplication is:"+(num1*num2));
            Console.WriteLine("Divsion is:"+(num1/num2));
            Console.WriteLine("Modulos is:"+(num1%num2));
        }
    }
}