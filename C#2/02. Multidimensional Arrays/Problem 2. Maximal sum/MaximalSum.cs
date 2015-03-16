using System;
/*
 * Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

namespace Problem_2.Maximal_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {

            //I've made it that way simply for ease of verification. If you want to check for different arrays, just uncomment!
            int[,] matrix = {
                                {1, 2, 3, 4, 5, 6, 7},
                                {7, 2, 1, 4, 5, 6, 2},
                                {17, -2, 1, -4, 5, 6, 2},
                                {-7, 2, 1, 4, -5, 6, -2},
                            };
            /*
             * int[,] matrix = {
                                {10, 20, 30, 4, 5, 6, 7},
                                {10, 20, 30, 4, 5, 6, 2},
                                {10, 20, 30, -4, 5, 6, 2},
                                {-7, 2, 1, 4, -5, 6, -2},
                            };
             * 
             * int[,] matrix = {
                                {1, 2, 3, 4, 5, 6, 7},
                                {7, 2, 1, 4, 10, 20, 30},
                                {17, -2, 1, 1, 20, 10, 30},
                                {-7, 2, 1, 4, 10, 20, 30},
             */


            int maxSum = int.MinValue;
            int currentSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) -2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row+1, col] + matrix[row+1, col + 1] + matrix[row+1, col + 2] +
                        matrix[row+2, col] + matrix[row+2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            Console.WriteLine("The maximum sum is: " + maxSum);
            Console.WriteLine("The 3x3 starts from row: " + startRow);
            Console.WriteLine("And column: " + startCol);

        }
    }
}
