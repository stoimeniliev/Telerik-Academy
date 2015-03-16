using System;
/*
 Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) / 2) * height;
            Console.WriteLine(area);
            
            
        }
    }
}
