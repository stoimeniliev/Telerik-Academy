using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            
            long mBeers = 0;
            long vBeers = 0;
            for (int i = 0; i < rounds; i++)
            {
                string drunkenNumbers = Console.ReadLine();
                long drunkenIntNumbers = Math.Abs(long.Parse(drunkenNumbers));
                long num = drunkenIntNumbers;
                long numberOfDigits = 0;
                while (num != 0)
                {
                    num = num / 10;
                    numberOfDigits++;
                }
                for (int n = 1; n <= numberOfDigits; n++)
                {


                    if ((numberOfDigits % 2) != 0)
                        {
                            if (n < (numberOfDigits / 2) + 1)
                            {
                                vBeers += drunkenIntNumbers % 10;
                                drunkenIntNumbers = drunkenIntNumbers / 10;
                            }
                            else if (n > (numberOfDigits / 2) + 1)
                            {
                                mBeers += drunkenIntNumbers % 10;
                                drunkenIntNumbers = drunkenIntNumbers / 10;
                            }
                            else if (n == (numberOfDigits / 2) + 1)
                            {
                                mBeers += drunkenIntNumbers % 10;
                                vBeers += drunkenIntNumbers % 10;
                                drunkenIntNumbers = drunkenIntNumbers / 10;
                            }
                        }
                    else if ((numberOfDigits % 2) == 0)
                        {
                            if (n <= numberOfDigits / 2)
                            {
                                vBeers += drunkenIntNumbers % 10;
                                drunkenIntNumbers = drunkenIntNumbers / 10;
                            }
                            else if (n >= numberOfDigits / 2)
                            {
                                mBeers += drunkenIntNumbers % 10;
                                drunkenIntNumbers = drunkenIntNumbers / 10;
                            }
                        }
                    }
                    
               
                //Console.WriteLine(drunkenNumbers.Length / 2);
                //Console.WriteLine("{0} beers for M, {1} beers for V", mBeers, vBeers);

            }
            
            if (mBeers > vBeers)
                Console.WriteLine("M" + " " + (mBeers - vBeers));  
            else if (vBeers > mBeers)
                Console.WriteLine("V" + " " + (vBeers - mBeers));
            else if (vBeers == mBeers )
                Console.WriteLine("No" + " " + (mBeers + vBeers));
             
        }
    }
}
