using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
    class Program
    {
        static void Main(string[] args)
        {
            string dot = ".";
            int h = int.Parse(Console.ReadLine());
            int counter = 7;
            int adder = 2;
            for (int i = 1; i <= h; i++)
            {
                
                for (int j = 0; j < h - i; j++)
                {
                    Console.Write(dot);
                }
                Console.Write("/");
                for (int k = 1; k < i; k++)
                {
                    if (i == 2 || i == 4)
                    {
                        Console.Write("--");
                    }
                    else if (i == counter)
                    {
                        Console.Write("--");
                        if (k == i - 1)
                        {
                            counter += (2 + adder);
                            adder++;
                        }
                        
                    }
                    else
                        Console.Write("..");
                }
                Console.Write("\\");
                for (int j = 0; j < h - i; j++)
                {
                    Console.Write(dot);
                }
                
                Console.WriteLine();
                    
                
               
            }
        }
    }
}
