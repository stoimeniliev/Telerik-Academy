using System;
/*
 * Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!
 */

namespace Problem_1.Say_Hello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your name");
            string name = Console.ReadLine();
            NewMethod(name);

        }

        private static void NewMethod(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
