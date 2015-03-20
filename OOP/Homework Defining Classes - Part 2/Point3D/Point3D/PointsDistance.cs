using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PointsDistance
    {

        public static decimal CalculateDistance(Point3D pointOne, Point3D pointTwo)
        {
            decimal distance = (decimal)Math.Sqrt(Math.Pow((double)pointOne.X - (double)pointTwo.X, 2) + Math.Pow((double)pointOne.Y - (double)pointTwo.Y, 2) + Math.Pow((double)pointOne.Z - (double)pointTwo.Z, 2));

            return distance;
        }



    }
}
