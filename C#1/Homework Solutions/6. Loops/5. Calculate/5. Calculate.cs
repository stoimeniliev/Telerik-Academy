using System;

//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//• Write a program that, for a given two integer numbers  n  and  x ,
//calculates the sum  S = 1 + 1!/x + 2!/x2+ … + n!/xn .
//• Use only one loop. Print the result with  5  digits after the decimal point.

//Examples:
//n   x   S
//3   2   2.75000 
//4   3   2.07407 
//5   -4  0.75781 

class Calculate
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double m = 1;
        
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            m = m * i;
            double mx = m / Math.Pow(x, i);
            sum +=  mx;
           
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
class Fibonacci
{
    
}