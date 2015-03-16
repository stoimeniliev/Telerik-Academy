using System;

//Problem 8. Catalan Numbers•
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
//• Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100). 

//Examples:
//n   Catalan(n)
//0   1 
//5   42 
//10  16796 
//15  9694845 

class Catalan_Numbers
{
    static void Main()
    {
        Console.WriteLine("Choose a number n, 1 < n < 100");
        int n = int.Parse(Console.ReadLine());
       
        double twoN = 1;
        double nPlusOne = 1;
        double fn = 1;
        
        for (int i = 1; i <= n; i++)
             fn = fn * i;
        for (int i = 1; i <= 2* n; i++)
            twoN = twoN * i;

        for (int i = 1; i <= (n+1); i++)
            nPlusOne = nPlusOne * i;

        Console.WriteLine((twoN)/(nPlusOne * fn));

    }
}
