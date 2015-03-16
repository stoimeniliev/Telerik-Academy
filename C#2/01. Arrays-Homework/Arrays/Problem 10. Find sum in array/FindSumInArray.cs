using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5
 */

namespace Problem_10.Find_sum_in_array
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {

            //if you'd like to change the variables, just uncomment!
            int findSum = 5;
            //int findSum = 50;
            //int findSum = -5;
            //int[] array = { 1, 2, 2, 3, 4, 3, 2, 1 };
            //int[] array = { 11, 2, 2, 10, 20, 20, 40, 1, 2, 2, 30, 20, 10 };
            int[] array = { 11, 2, -1, 6, 20, 20, 40, 1, 25, 2, 30, 20, 10 };

            int startIndex = 0;
            int indexLength = 0;
            int currentSum = array[0];
            bool found = false;
            if (currentSum == findSum)
            {
                Console.WriteLine("desired sum: " + findSum + "elements: " + currentSum);

            }
            else
            {
                while (found == false)
                {

                    for (int i = 1; i < array.Length; i++)
                    {
                        for (int j = i; j < array.Length; j++)
                        {
                            if (currentSum + array[j] < findSum)
                            {
                                currentSum += array[j];
                                indexLength++;

                            }
                            else if (currentSum + array[j] == findSum)
                            {
                                indexLength++;
                                currentSum += array[j];
                                found = true;
                                break;
                            }
                            else
                            {
                                currentSum = 0;
                                startIndex = j + 1;
                                indexLength = 1;
                            }

                        }
                        if (i == array.Length - 1)
                        {
                            Console.WriteLine("There is no such sequence");
                            found = true;
                        }
                        else if (found == true)
                        {
                            break;
                        }

                    }
                    if (startIndex == 0)
                    {
                        Console.Write("Desired sum {0} is present, the elements are: ", findSum);
                        for (int k = startIndex; k < startIndex + indexLength + 1; k++)
                        {
                            Console.Write(array[k] + ", ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Desired sum {0} is present, the elements are: ", findSum);
                        for (int k = startIndex; k < startIndex + indexLength - 1; k++)
                        {
                            Console.Write(array[k] + ", ");
                        }
                        Console.WriteLine();
                    }

                }
            }

        }
    }
}
