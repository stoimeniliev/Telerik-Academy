using System;
/*
 Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
 */

namespace OddorEven
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            int oddEven = int.Parse(Console.ReadLine());
            bool isOddEven = (oddEven % 2 == 0);
            Console.WriteLine(isOddEven);
            
        }
    }
}
