using System;

//Problem 7. Calculate N! / (K! * (N-K)!)
//• In combinatorics, the number of ways to choose  k  different members out 
//of a group of  n  different elements (also known as the number of combinations)
//is calculated by the following formula: "https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png"
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck 
//of 52 cards.• Your task is to write a program that calculates  n! / (k! * (n-k)!)
//for given  n  and  k  (1 < k < n < 100). Try to use only two loops.

//Examples:
//n   k   n! / (k! * (n-k)!)
//3   2   3 
//4   2   6 
//10  6   210 
//52  5   2598960 

class Calculate 
{
    static void Main()
    {
        Console.WriteLine("Choose a number n, 1 < n < 100");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a number k, 1 < k < n");
        int k = int.Parse(Console.ReadLine());
        double fn = 1;
        double fk = 1;
        double fkn = 1;
        for (int i = 1; i <= n; i++)
        {
            if (k >= i)
            {
                fk = fk * i;
                
            }
            if (n - k >= i)
            {
                fkn = fkn * i;
                
            }
            fn = fn * i;
        }
        Console.WriteLine(fn/ (fk * fkn));

    }
}
