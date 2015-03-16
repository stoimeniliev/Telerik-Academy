

using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 */

class SequenceiNMatrix
{
    static void Main()
    {
        //To change the input, simply uncomment
        string[,] matrix = new string[,]
        {
            {"ha","fifi","ho","hi"},
            {"fo","ha","hi","xx"},
            {"xxx","ho","ha","xx"}
        };
        /* string[,] matrix = new string[,]
        {
             {"s","qq","s"},
             {"pp","pp","s"},
             {"pp","qq","s"}
        };
        */
        
        string element = string.Empty;
        int currentMax = 1;
        int max = 1;
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentMax = 1;

                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentMax++;
                }
                else
                {
                    currentMax = 1;
                }

                if (currentMax > max)
                {
                    max = currentMax;
                    element = matrix[row, col];
                }
            }
            currentMax = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentMax++;
                }
                else
                {
                    currentMax = 1;
                }

                if (currentMax > max)
                {
                    max = currentMax;
                    element = matrix[row, col];
                }
            }

            currentMax = 1;
        }
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentMax++;
            }
            else
            {
                currentMax = 1;
            }

            if (currentMax > max)
            {

                max = currentMax;
                element = matrix[row, col];
            }
        }
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-6}", matrix[row, col]);
            }
            Console.WriteLine();
        }
       
        Console.WriteLine("Result: ");
        for (int i = 0; i < max; i++)
        {
            Console.Write(i < max - 1 ? "{0}, " : "{0}", element);
        }
        Console.WriteLine();
    }
}