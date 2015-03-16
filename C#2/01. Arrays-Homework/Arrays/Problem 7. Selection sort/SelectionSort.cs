using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc
 */
namespace Problem_7.Selection_sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers of elements in the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int min = array[0];
            for (int j = 0; j < n - 1; j++)
            {

                min = j;

                for (int i = j + 1; i < n; i++)
                {

                    if (array[i] < array[min])
                    {

                        min = i;
                    }
                }

                if (min != j)
                {

                    temp = array[j];
                    array[j] = array[min];
                    array[min] = temp;
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
