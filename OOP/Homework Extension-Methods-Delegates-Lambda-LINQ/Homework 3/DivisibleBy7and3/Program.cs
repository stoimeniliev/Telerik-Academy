using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {

            


            int[] numbers = { 3, 4, 5, 6, 7, 8, 9, 10, 21 };
            Console.WriteLine("The array of numbers to filter is: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            List<int> numbersNormal = Divisible(numbers);
            Console.WriteLine("Problem 6 solution without LINQ");
            foreach (var item in numbersNormal)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int[] numbersLINQ = DivisibleLINQ(numbers);
            Console.WriteLine("Problem 6 solution with LINQ");
            foreach (var item in numbersLINQ)
            {
                Console.Write(item + " ");
            }
        }
            
        
        
        
        
        public static List<int> Divisible(int[] array)
            {
                List<int> divisibleNumbers = new List<int>();
                foreach (var item in array)
                {
                    if (item % 3 == 0 || item % 7 == 0)
                    {
                        divisibleNumbers.Add(item);
                    }
                }
                
            return divisibleNumbers;
            }


        public static int[] DivisibleLINQ(int[] array)
        {
            

            return array.Where(x => x % 3 == 0 || x % 7 == 0).ToArray();
        }
        
    }
}
