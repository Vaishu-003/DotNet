using System;
namespace thite
{
    class Pro{
        static void Main(string[] args){

            int num=20;
            object obj=num;

            Console.WriteLine("Boxing:");
            Console.WriteLine("The value-type is:"+num);
            Console.WriteLine("The Boxed Value is:"+obj);


            //Unboxing 
            object obj2=400;
            int num2=(int)obj2;

            Console.WriteLine("Unboxing:");
            Console.WriteLine("Boxed-Value is:"+obj2);
            Console.WriteLine("UnBoxed-Value is:"+num2);



        }

    }
}