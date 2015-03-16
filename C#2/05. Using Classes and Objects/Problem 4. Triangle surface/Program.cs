using System;

/*
 * Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

namespace Problem_4.Triangle_surface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal side1 = 5.0m;
            decimal side2 = 6.0m;
            decimal side3 = 3.0m;

            decimal height = 3.0m;
            decimal angle12 = 30.0m;

            decimal area;
            area = AllSides(side1, side2, side3);
            Console.WriteLine("Three sides: {0}", area);

            area = HeightSide(side1, height);
            Console.WriteLine("Side and an altitude to it: {0}", area);

            area = SideAngle(side1, side2, angle12);
            Console.WriteLine("Two sides and an angle between them: {0}", area);

        }

        private static decimal SideAngle(decimal side1, decimal side2, decimal angle12)
        {
            angle12 = angle12 * (decimal)Math.PI / 180.0m;
            return ((decimal)Math.Sin((double)angle12) * side1 * side2) / 2.0m;
        }

        private static decimal HeightSide(decimal side1, decimal height)
        {
            return (side1 * height) / 2.0m;
        }

        private static decimal AllSides(decimal side1, decimal side2, decimal side3)
        {
            decimal p = (side1 + side2 + side3) / 2;
            return (decimal)Math.Sqrt((double)(p * (p - side1) * (p - side2) * (p - side3)));
        }
    }
}
