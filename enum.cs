using System;
namespace thite{
    class Rev{
        static void Main(String[] args){

            int n;

            Console.WriteLine("Enter the size of array:");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Array Elements:");
            int[] arr =new int[n];
            for(int i=0;i<n;i++){

                arr[i]=Convert.ToInt32(Console.ReadLine());

            }

            Array.Reverse(arr);
            Console.WriteLine("Reversed Array is:");
            for(int i=0;i<arr.Length;i++){
                Console.WriteLine(+arr[i]);
            }


        }
    }
}