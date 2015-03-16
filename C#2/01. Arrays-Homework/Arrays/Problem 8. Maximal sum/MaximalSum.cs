using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:

input	
2, 3, -6, -1, 2, -1, 6, 4, -8, 8
 * 
 * result 2, -1, 6, 4
 */

namespace Problem_8.Maximal_sum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Length of the array");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            Console.WriteLine("Enter the Array numbers:");
            for (int i = 0; i < lenght; i++)
            {

                array[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = array[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;
            int maxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                    tempStartIndex = i;
                }
                else
                {
                    currentSum += array[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }

            Console.WriteLine("The best sum is: {0} ", maxSum);

            Console.WriteLine("The best sequence is:");

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
