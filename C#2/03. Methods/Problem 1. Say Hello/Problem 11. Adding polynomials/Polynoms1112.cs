using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */

namespace Problem_11.Adding_polynomials
{
    class Polynoms1112
    {

        static void Main()
        {
            //I'm using preselected polynoms
            Console.WriteLine("Adding: ");
            Printing(Add(new int[] { 3, 4, 1 }, new int[] { 5, 1, 2, 6 }));
            Console.WriteLine();
            Console.WriteLine("Multiply: ");
            MultPolyn(new int[] { 3, 4, 1 }, new int[] { 5, 1, 2, 6 });
            Console.WriteLine();
            Console.WriteLine("Subtracting: ");
            SubPolyn(new int[] { 3, 4, 1 }, new int[] { 5, 1, 2, 6 });
            Console.WriteLine();
        }
        static void Printing(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + "*x^" + i + (i == 0 ? "\n" : " + "));
            }
        }

        static int[] Add(int[] a, int[] b)
        {
            if (a.Length > b.Length)
            {
                return Add(b, a);
            }
            Printing(a);
            Printing(b);
            int[] final = new int[b.Length];

            int i = 0;
            for (; i < a.Length; i++)
            {
                final[i] = a[i] + b[i];
            }
            for (; i < b.Length; i++)
            {
                final[i] = b[i];
            }
            return final;
        }

        static int[] SubPolyn(int[] a, int[] b, bool backwards = false)
        {
            if (a.Length > b.Length)
            {
                return SubPolyn(b, a, backwards = true);
            }
            Printing(a);
            Printing(b);
            int[] final = new int[b.Length];
            int i = 0;
            for (; i < a.Length; i++)
            {
                final[i] = (backwards ? b[i] - a[i] : a[i] - b[i]);
            }
            for (; i < b.Length; i++)
            {
                final[i] = (!backwards ? b[i] : -b[i]);
            }
            Printing(final);
            return final;
        }

        static int[] MultPolyn(int[] a, int[] b)
        {
            Printing(a);
            Printing(b);
            int[] final = new int[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    final[i + j] = a[i] * b[j];
                }
            }
            Printing(final);
            return final;
        }

        
    }
}
