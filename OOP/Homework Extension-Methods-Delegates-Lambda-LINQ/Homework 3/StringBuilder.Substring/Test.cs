using System;
using System.Text;
namespace ExtensionClass
{

    class Test
    {
        public static void Main()
        {
            var builder = new StringBuilder("im an extended stringbuilder!");

            var subBuilder = ExtensionMethods.Substring(builder, 15, builder.Length - 15);

            Console.WriteLine(subBuilder);

            var nums = new int[] { 1,2,3,4,5,6,7,-1,-100,0 };
            
            Console.WriteLine("sum: " + ExtensionMethods.Sum(nums));
            Console.WriteLine("min: " + ExtensionMethods.Min(nums));
            Console.WriteLine("max: " + ExtensionMethods.Max(nums));
            Console.WriteLine("average: " + ExtensionMethods.Average(nums));
            Console.WriteLine("product: " + ExtensionMethods.Product(nums));



        }
    }
}