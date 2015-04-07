using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Test
    {
        static void Main()
        {
            var firstPirson = new Person();

            firstPirson.Name = "Ivaylo";
            firstPirson.Age = 20;

            var secondPerson = new Person();

            secondPerson.Name = "Bojidar";

            Console.WriteLine(firstPirson);
            Console.WriteLine(secondPerson);
        }
    }
}
