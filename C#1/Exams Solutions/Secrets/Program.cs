using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Secrets
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            if (n < 0)
            {
                n = n * -1;
            }
            BigInteger nn = n;
            BigInteger temp = n;
            BigInteger counter = 0;
            BigInteger sum = 0;
            BigInteger k = 0;


            while (temp > 0)
            {
                temp = temp / 10;
                counter++;
            }
            for (BigInteger i = 1; i <= counter; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (n % 10) * (n % 10) * i;

                }

                else if (i % 2 != 0)
                {
                    sum += (n % 10) * i * i;
                }

                n = n / 10;

            }
            BigInteger tempsum = sum;
            while (tempsum > 26)
            {
                tempsum = tempsum - 26;
            }
            if (sum % 10 == 0)
            {
                Console.WriteLine(sum);
                Console.WriteLine(nn + " has no secret alpha-sequence");
            }
            else
            {
                Console.WriteLine(sum);
                for (BigInteger j = 0; j < sum % 10; j++)
                {
                    BigInteger broq = (65 + tempsum + k);
                    if (broq > 90)
                    {
                        broq -= 26;
                    }
                    char c = (char)broq;
                    k++;
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
