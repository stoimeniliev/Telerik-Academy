using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 */
namespace Problem_14.Integer_calculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many integers? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the integers: ");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Minimum number " + GetMinimum(array));
            Console.WriteLine("Maximum number " + GetMaximum(array));
            Console.WriteLine("Average " + GetAverage(array));
            Console.WriteLine("Sum " + GetSum(array));
            Console.WriteLine("Product " + GetProduct(array));
        }

        private static double GetAverage(int[] array)
        {
            double average = 1;
            foreach (var item in array)
            {
                average += item;
            }
            return average / array.Length;
        }

        private static int GetProduct(int[] array)
        {
            int product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            return product;
        }

        private static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        private static int GetMaximum(int[] array)
        {
            int num = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > num)
                {
                    num = array[i];
                }
            }
            return num;
        }

        private static int GetMinimum(int[] array)
        {
            int num = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < num)
                {
                    num = array[i];
                }
            }
            return num;
        }
    }
}
