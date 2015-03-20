using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{

    public class PointsMain
    {
        public static void Main(String[] args)
        {

            //Just creating some 3D Points
            var tochka = new Point3D(1.1m, 2.2m, 3.3m);
            var tochkaTwo = new Point3D(2.1m, 3.2m, 4.3m);
            var tochkaThree = new Point3D(1.1m, 2.2m, 3.3m);
            var tochkaFour = new Point3D(2.1m, 3.2m, 4.3m);


            //Problem 2: Calculating distance:

            Console.WriteLine("The distance between the two points is: {0:F4}",PointsDistance.CalculateDistance(tochka, tochkaTwo));


            //Problem 3 - Adding Paths.
            Path myPath = new Path();
            myPath.AddPoint(tochka);
            myPath.AddPoint(tochkaTwo);
            myPath.AddPoint(tochkaThree);

            //Problem 4. Tests:


            //Name of the path + desired name of the save file. It will be located in:
            PathStorage.SavePath(myPath, "Path Pesho.txt");
            Console.WriteLine("This is what I read from the file!");
            Console.WriteLine(PathStorage.LoadFromFile("Path Pesho.txt"));
            
            






        }
    }
}