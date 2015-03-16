using System;
/*
 Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */

namespace BitwiseExtractBit
{
    class Bitwise
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            int mask = 1 << 3;
            int result = mask & userInput;
            result = result >> 3;
            Console.WriteLine(result);
           
        }
    }
}
