using System;
/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()
 */


namespace Problem_2.Get_largest_number
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 3: ");
            int numThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Biggest of 1 and 2 is: " + GetMax(numOne, numTwo));
            Console.WriteLine("Biggest of 1, 2 and 3 is: " + GetMax(GetMax(numOne, numTwo), numThree));

        }

        private static int GetMax(int numOne, int numTwo)
        {
            if (numOne >= numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }

        }
    }
}
