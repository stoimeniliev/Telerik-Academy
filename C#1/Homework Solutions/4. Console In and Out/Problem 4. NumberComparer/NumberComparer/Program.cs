using System;
/*
 Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */
namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int c = numberOne - numberTwo;
            int k = (c >> 31) & 0x1;
            int max = numberOne - k * c;
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
