using System;
using System.Linq;
/*
 * Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

	
input "43 68 9 23 318"	output 461
 */

namespace Problem_6.Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "43 68 9 23 318";
            int[] nums = numbers.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(nums.Sum());
        }
    }
}
