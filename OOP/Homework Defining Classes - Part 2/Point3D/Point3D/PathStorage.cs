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
        public static string ReadPath(string fileName)
        {


            using (StreamReader streamReader = new StreamReader(fileName))
            {
                while (true)
                {
                    string line = streamReader.ReadLine();
                    if (line == null)
                    {
                        return "";
                    }

                    try
                    {
                        return line;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Some error while reading!");
                    }

                }
            }
        }

        public static string LoadFromFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                return reader.ReadToEnd();
            }
        }
    }





}


