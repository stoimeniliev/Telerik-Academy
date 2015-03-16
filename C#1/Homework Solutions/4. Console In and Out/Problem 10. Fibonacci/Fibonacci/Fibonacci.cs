using System;
/*
Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
 */

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int fib = int.Parse(Console.ReadLine());
            int sum = 1;
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < fib; i++)
            {
                if (i == 0)
                {
                    
                    Console.Write(0 + " ");
                }
                else if (i == 1)
                {
                    sum = 1;
                Console.Write(sum + " ");}

                else
                {
                    counter2 = counter;
                    counter = sum;
                    sum = sum + counter2;
                    Console.Write(sum + " ");
                }
                
            }
        }
    }
}
