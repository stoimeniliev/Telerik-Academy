using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAtPosition
{
    class BitAtPosition
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            
            int position = int.Parse(Console.ReadLine());
            bool isOne = (number >> position & 1) == 1;
            Console.WriteLine(isOne);
        }
    }
}
