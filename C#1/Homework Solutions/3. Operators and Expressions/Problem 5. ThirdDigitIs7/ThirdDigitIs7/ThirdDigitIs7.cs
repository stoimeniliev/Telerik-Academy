using System;
/*
 Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            int intInput = int.Parse(Console.ReadLine());            
            bool isSeven = ((intInput / 100) % 10 == 7);
            Console.WriteLine(isSeven);
            
        }
    }
}
