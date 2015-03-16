using System;
/*
Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */
namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
            
        {

            Console.WriteLine("Write a, b c, which represent the variables in the following equation ax^2 + bx + c = 0");
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC= double.Parse(Console.ReadLine());

            double determinant = numberB * numberB - 4 * numberA * numberC;
            double rootOne;
            double rootTwo;

            if (determinant == 0)
            {
                rootOne = rootTwo = -numberB / (2 * numberA);
                Console.WriteLine("There's only one root x={0}",rootOne);
                
            }
            else if (determinant < 0)
            {
                Console.WriteLine("Sorry mate, no solutions!");
                
            }
            else
            { 
                rootOne = (-numberB - Math.Sqrt(determinant)) / (2 * numberA);
                rootTwo = (-numberB + Math.Sqrt(determinant)) / (2 * numberA);
                Console.WriteLine("Root x1 = {0} and root x2={1}.", rootOne, rootTwo);
                
            }
        }
    }
}
