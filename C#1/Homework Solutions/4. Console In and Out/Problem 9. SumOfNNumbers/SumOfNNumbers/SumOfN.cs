using System;
/*
 Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
Examples:
 */

namespace SumOfNNumbers
{
    class SumOfN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of N's?:");
            double numN = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < numN; i++)
            {
                double nums = double.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
