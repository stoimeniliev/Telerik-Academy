using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

		/*
		Here's the issue:
		http://bgcoder.com/Contests/Practice/DownloadResource/513
		*/
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int M = A % C;
            int R;

            if (B == 2)
            {
               R = A % C;
               
               if (R % 4 == 0)
                {
                    Console.WriteLine(R / 4);
                    Console.WriteLine(R);
                }
                else if (R % 4 != 0)
                {
                    Console.WriteLine(R % 4);
                    Console.WriteLine(R);
                }
                
            }
              
            else if (B == 4)
            {
                R = A + C;
                if (R % 4 == 0)
                {
                    Console.WriteLine(R / 4);
                    Console.WriteLine(R);
                }
                else if (R % 4 != 0)
                {
                    Console.WriteLine(R % 4);
                    Console.WriteLine(R);
                }
            }
              
            else if (B == 8)
            {
                R = A * C;
                if (R % 4 == 0)
                {
                    Console.WriteLine(R / 4);
                    Console.WriteLine(R);
                }
                else if (R % 4 != 0)
                {
                    Console.WriteLine(R % 4);
                    Console.WriteLine(R);
                }
            }
     
              
        }
    }
}
