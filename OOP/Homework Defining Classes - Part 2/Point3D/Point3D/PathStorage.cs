using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Point3D
{
    public static class PathStorage
    {

        //private StreamReader Reader = new StreamReader();

        //This method takes the desired path + the name of the destination file. It will save in Homework Defining Classes - Part 2\Point3D\Point3D\bin\Debug
        public static void SavePath(Path myPath, string name)
        {
            StreamWriter Writer = new StreamWriter(name);

            using (Writer)
            {

                foreach (var path in myPath.PointList)
                {
                    Writer.WriteLine(path);
                }

            }
            Writer.Close();


        }
        //This method reads the desired file containing a Path. Found in "Homework Defining Classes - Part 2\Point3D\Point3D\bin\Debug"


        public static Path LoadFromFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName + ".txt");
            Path loadedPath = new Path();
            Point3D currentPoint3D = new Point3D();
            using (reader)
            {
                while (reader.EndOfStream == false)
                {
                    string[] separators = new string[]
                    {
                        "{{",
                        "}}",
                        "{",
                        "}",
                        ";"
                    };
                    string currentRow = reader.ReadLine();
                    string[] currentPoint = currentRow.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    currentPoint3D.X = decimal.Parse(currentPoint[0]);
                    currentPoint3D.Y = decimal.Parse(currentPoint[1]);
                    currentPoint3D.Z = decimal.Parse(currentPoint[2]);
                    loadedPath.AddPoint(currentPoint3D);
                }
            }
            reader.Close();
            return loadedPath;
        }
    }





}


