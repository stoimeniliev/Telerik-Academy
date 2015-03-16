using System;
/*
Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberA = number / 1000;
            int numberB = (number / 100) % 10;
            int numberC = (number / 10) % 10;
            int numberD = number % 10;

            Console.WriteLine("Sum of all numbers: " + (numberA + numberB + numberC  + numberD));
            Console.WriteLine("Number in reversed order (dcba): " + numberD + numberC + numberB + numberA);
            Console.WriteLine("Number in dabc order: " + numberD + numberA + numberB + numberC);
            Console.WriteLine("Number in acbd order: " + numberA + numberC + numberB + numberD);

        }
    }
}
