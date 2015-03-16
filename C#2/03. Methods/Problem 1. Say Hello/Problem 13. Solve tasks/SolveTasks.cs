using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

namespace Problem_13.Solve_tasks
{
	class SolveTasks
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please choose what you want to do from 1, 2, 3");
			Console.WriteLine("1. Reverse the digits of a number");
			Console.WriteLine("2. Calculate the average of a sequence of integers");
			Console.WriteLine("3. Solve a linear calculation a * x + b = 0");
			string choice = Console.ReadLine();
			switch (choice)
	{
		case "1":
			{
				Console.WriteLine("Please write a number");
				decimal num = decimal.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("You should have written a non-negatve number!" );
                    
                }
                else
                {
                    Console.WriteLine(GetReversed(num));
                    
                }
                break;
			}
		case "2":
			{
				Console.WriteLine("How many numbers in the sequence?");
				int m = int.Parse(Console.ReadLine());
				
				int[] numbers = new int[m];
				if (m <= 0)
				{
					Console.WriteLine("You should have entered at least one element");
				}
				else
				{
					Console.WriteLine("Please write the numbers ");
					for (int i = 0; i < m; i++)
					{
						
						numbers[i] = int.Parse(Console.ReadLine());
					}

					Console.WriteLine("Average is :" + GetAverage(numbers));
				}
				break;
			}

		case "3":
            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("A should not be zero!");
            }
            else
            {
                Console.WriteLine("X = " + SolveEquation(a, b));
            }
            break;
        default:
            Console.WriteLine("Invalid input!");
            break;
	}
		}

        private static double SolveEquation(double a, double b)
        {
            double x = (b / a) * (-1);
            return x;
        }

		private static double GetAverage(int[] numbers)
		{
			double sum = 0;
			foreach (var item in numbers)
			{
				sum = sum + item;
			}
			return sum/numbers.Length;
		}

		private static decimal GetReversed(decimal number)
		{
			return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
		}
	}
}
