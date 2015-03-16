using System;
using System.Linq;

/*
 * Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
 */
namespace Problem_7.Reverse_number
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Write a number ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversed = GetReversed(number);
            Console.WriteLine("Reversed number is {0}", reversed);
        }

        private static decimal GetReversed(decimal number)
        {
            return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
        }
    }
}
