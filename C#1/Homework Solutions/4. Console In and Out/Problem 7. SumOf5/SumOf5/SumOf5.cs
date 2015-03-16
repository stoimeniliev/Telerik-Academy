using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fiveNum = Console.ReadLine();
            string[] fiveSeparated = fiveNum.Split(new Char[] { ' ' });
            double nums = 0.0;
            for (int i = 0; i < fiveSeparated.Length; i++)
            {

                nums += double.Parse(fiveSeparated[i]);
                
            }
            Console.WriteLine(nums);
        }
    }
}
