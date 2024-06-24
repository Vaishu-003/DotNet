using System;
	
class Prime 
{
    static bool isPrime(int n){
        if(n==1||n==0)return false;
	    for(int i=2; i<=n/2; i++){
		if(n%i==0)return false;
	    }
    return true;
    }


    public static void Main (String[] args) 
    { 
        Console.WriteLine("Enter number upto which you want prime number:");
	    int N =Convert.ToInt32(Console.ReadLine()); 
	    for(int i=1; i<=N; i++){
	    if(isPrime(i)) {
		    Console.Write(i + " "); 
	    }
}
	
}
}