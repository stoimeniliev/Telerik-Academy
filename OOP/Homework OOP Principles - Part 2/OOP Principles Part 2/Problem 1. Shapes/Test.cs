using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shapes
{
    class Test
    {
        static void Main(string[] args)
        {

            Shape square = new Square(10);
            Console.WriteLine("The surface of the square is: " + square.CalculateSurface());

            Shape triangle = new Triangle(2, 4);
            Console.WriteLine("The surface of the triangle is: " + triangle.CalculateSurface());

            Shape rectangle = new Rectangle(10.2, 12.8);
            Console.WriteLine("The surface of the rectangle is: " + rectangle.CalculateSurface());
        }
    }
}
