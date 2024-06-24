using System;
namespace thite
{
    class Star{
        static void Main(string[] args){
            int i,j,n,k;
            Console.WriteLine("Enter the rows:");
            n=Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++) { 
                for (j = 0; j < 2 * (n- i) - 1; j++) { 
                Console.Write(" "); 
                } 
                for (k = 0; k <= i ; k++) { 
                Console.Write("* "); 




            } 


            Console.WriteLine();         
        }
    }
}
}