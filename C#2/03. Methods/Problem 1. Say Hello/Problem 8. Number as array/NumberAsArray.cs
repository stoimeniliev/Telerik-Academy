using System;
/*
 * Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */

namespace Problem_8.Number_as_array
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {

            //So, as far as I understood, the method receives integer arrays in which the number'
            int[] arrOne = { 1, 2, 4};
            int[] arrTwo = { 1, 2, 4, 5};
            //int[] arrOne = { 1, 2, 4, 3, 5, 6 };
            //int[] arrTwo = { 1, 2, 4, 3, 5, 6 };
            //int[] arrTwo = { 6, 5, 4, 3, 2, 1 };

            
            foreach (var item in AddArr(arrOne, arrTwo))
            {
                Console.Write(item);
            }
        }

        private static int[] AddArr(int[] arrOne, int[] arrTwo)
        {
            int size = 0;
            if (arrOne.Length > arrTwo.Length)
            {
                size = arrOne.Length;
            }
            else
            {
                size = arrTwo.Length;
            }
            Array.Reverse(arrOne);
            Array.Reverse(arrTwo);
            int[] arrSum =new int[size+1];
            int arrO = 0;
            int arrT = 0;

            for (int i = 0; i < size; i++)
            {
                if (i >= arrOne.Length)
                {
                    arrO = 0;
                }
                else
                {
                     arrO = arrOne[i];
                }

                if (i >= arrTwo.Length)
                {
                    arrT = 0;
                }
                else
                {
                    arrT = arrTwo[i];
                }

                arrSum[i] = arrO + arrT;

                if (arrSum[i] > 9)
                {
                    arrSum[i + 1] = arrSum[i] - 9;
                    arrSum[i] = 9;
                }
            }
            return arrSum;
        }
    }
}
