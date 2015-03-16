using System;
/*
Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */

namespace PointsInACircle
{
    class PointsInCircle
    {
        static void Main(string[] args)
        {
            //I want the absolute values of the variables so that I don't have to work with the negative ones
            double pointX = Math.Abs(double.Parse(Console.ReadLine()));
            double pointY = Math.Abs(double.Parse(Console.ReadLine()));
            //I want to check how far is that point from the radius. This is like finding the hypotenuse of an triangle.
            double hypotenusе = Math.Sqrt((pointX * pointX) + (pointY * pointY));
            bool isItIn = (hypotenusе <= 2);
            Console.WriteLine(isItIn);
            

        }
    }
}
