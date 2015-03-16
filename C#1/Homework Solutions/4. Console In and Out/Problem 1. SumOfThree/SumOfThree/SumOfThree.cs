using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
 */

namespace SumOfThree
{
    class SumOfThree
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            Console.WriteLine(numOne + numTwo + numThree);
        }
    }
}
