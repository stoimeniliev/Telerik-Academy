using System;
/*
 * Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n = 100) is prime 
 * (i.e. it is divisible without remainder only to itself and 1).
 */

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int isPrime = int.Parse(Console.ReadLine());
            
            if (isPrime < 2)
            {
                
                Console.WriteLine("false");
                
            }
            else
            {
                for (int i = 2; i < isPrime; i++)
                {
                    if (isPrime % i == 0)
                    {
                        Console.WriteLine("false");
                        
                    }
                    
                }
                Console.WriteLine("true");
                
            }
            
            
        }
    }
}
