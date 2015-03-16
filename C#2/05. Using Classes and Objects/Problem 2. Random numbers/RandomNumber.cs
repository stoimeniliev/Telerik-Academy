using System;


using System.Threading.Tasks;

/*
 * Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

namespace Problem_2.Random_numbers
{
    class RandomNumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(100, 201));
            }
        }
    }
}
