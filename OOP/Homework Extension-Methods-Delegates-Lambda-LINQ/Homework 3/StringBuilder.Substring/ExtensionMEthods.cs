using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */

namespace ExtensionClass
{

  
    public static class ExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                strb.Append(sb[i+startIndex]);
            }
            return strb;

        }

        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            dynamic sum = 0;
            foreach (var element in collection)
                sum += element;

            return sum;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            T min = collection.First();
            foreach (var element in collection)
                if (element.CompareTo(min) < 0)
                    min = element;

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            T max = collection.First();
            foreach (var element in collection)
                if (element.CompareTo(max) > 0)
                    max = element;

            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            double sum = 0.0;
            return (dynamic)collection.Aggregate(sum, (acc, val) => acc + (dynamic)val) / (dynamic)collection.Count();
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T product = (dynamic)1;
            return collection.Aggregate(product, (acc, val) => acc * (dynamic)val);
        }
    }
}
