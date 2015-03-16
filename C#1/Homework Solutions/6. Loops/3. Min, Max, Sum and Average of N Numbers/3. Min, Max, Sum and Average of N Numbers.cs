﻿using System;

//Problem 3. Min, Max, Sum and Average of N Numbers
//• Write a program that reads from the console a sequence of  n  integer numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
//• The output is like in the examples below.

//Example 1:
//input       output
//3           min = 1 
//2           max = 5 
//5           sum = 8 
//1           avg = 2.67 

//Example 2:
//input       output
//2           min = -1 
//-1          max = 4 
//4           sum = 3 
//            avg = 1.50 

class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers?");
        int numbers = int.Parse(Console.ReadLine());
        double current;
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        double previous = 0;
        for (int i = 0; i < numbers; i++)
        {
            current = double.Parse(Console.ReadLine());
            
            sum = sum + current;
            if (i==0)
            {
                previous = current;
            }
            if (current >= max)
            {
                max = current;
                
                
                if (previous <= min)
                {
                    min = previous;
                }
                

            }
            else if (current < previous)
            {
                min = current;
                previous = current;
            }
            
        }
        Console.WriteLine("sum " + sum);
        Console.WriteLine("average " + (sum / numbers));
        Console.WriteLine("max " + max);
        Console.WriteLine("min " + min);
    }
}
