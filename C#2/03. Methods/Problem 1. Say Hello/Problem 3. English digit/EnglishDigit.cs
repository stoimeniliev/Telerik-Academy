using System;
/*
 * Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
 */
namespace Problem_3.English_digit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an int:");
            int num = int.Parse(Console.ReadLine());
            GetEnglish(num);
        }

        private static void GetEnglish(int num)
        {
            if (num % 10 == 1)
            {
                Console.WriteLine("one");
            }
            else if (num % 10 == 2)
            {
                Console.WriteLine("two");
            }
            else if (num % 10 == 3)
            {
                Console.WriteLine("three");
            }
            else if (num % 10 == 4)
            {
                Console.WriteLine("four");
            }
            else if (num % 10 == 5)
            {
                Console.WriteLine("five");
            }
            else if (num % 10 == 6)
            {
                Console.WriteLine("six");
            }
            else if (num % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num % 10 == 9)
            {
                Console.WriteLine("nine");
            }
            else if (num % 10 == 0)
            {
                Console.WriteLine("zero");
            }

        }
    }
}
