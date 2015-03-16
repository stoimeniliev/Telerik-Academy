using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int mask = ~(1 << position);
            int changer = value << position;
            number = (number & mask) | changer;
            Console.WriteLine(number);


        }
    }
}
