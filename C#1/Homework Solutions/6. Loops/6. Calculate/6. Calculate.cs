using System;

//Problem 6. Calculate N! / K!
//• Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
//• Use only one loop.

//Examples:
//n       k       n! / k!
//5       2       60 
//6       5       6 
//8       3       6720 

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Write a number from 1 do 100");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Write a number from 1 to " + n);
        double k = double.Parse(Console.ReadLine());
        double fn = 1;
        double fk = 1;
        for (int i = 1; i <= n; i++)
        {
            if (k >= i)
            {
                fk = fk * i;
                
            }
            fn = fn * i;

        }
        Console.WriteLine(fn/fk);
    }
}
