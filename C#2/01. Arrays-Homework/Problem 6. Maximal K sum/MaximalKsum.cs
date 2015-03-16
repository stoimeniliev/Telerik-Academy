using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */

namespace Problem_6.Maximal_K_sum
{
    class MaximalKsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lengt of array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("numbr of elements max sum");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] l = new int[n];
            int largest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                l[i] = int.Parse(Console.ReadLine());
            }
            for (int m = 0; m < k; m++)
            {

                int i = 0;
                for (; i < n; i++)
                {

                    if (l[i] > largest)
                    {
                        largest = l[i];
                    }
                }
                sum = sum + largest;
                for (int o = 0; o < n; o++)
                {
                    if (l[o] == largest)
                    {
                        l[o] = int.MinValue;
                        largest = int.MinValue;
                    }
                }


            }
            Console.WriteLine(sum);
        }
    }
}
