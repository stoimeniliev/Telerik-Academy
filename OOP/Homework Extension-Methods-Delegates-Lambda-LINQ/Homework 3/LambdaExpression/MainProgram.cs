using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Student(string firstName, string lastName, int age, string FN, string Tel, byte group, string email)
            List<byte> marksExcelent = new List<byte>() { 6 };
            List<byte> marks = new List<byte>() { 2, 3, 4, 5 };
            Students[] group10 = new Students[]
                {
                    new Students("Bboyan","Aaronov", 22, "06", "0283462942", 1, "tito@email.com"),
                    new Students("Aaron","Bbachev", 23, "76062", "0883462942", 2, "tito@abv.bg"),
                    new Students("Aleks","Zelev", 30, "060606", "0283462942", 3, "tito@email.com"),
                    new Students("Sergio","Aguero", 21, "06642", "0883462942", 4, "tito@abv.bg"),
                };
            group10[0].AddMark(6);
            group10[1].AddMark(6);
            group10[2].AddMark(5);
            group10[3].AddMark(2);
            group10[3].AddMark(2);
            Students[] firstBeforeLast = Students.FirstBeforeLast(group10);
            Console.WriteLine();
            Console.WriteLine("Problem 3. First before last");
            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine(item);
            }

            Students[] ageRange = Students.AgeRange(group10, 18, 24);
            Console.WriteLine();
            Console.WriteLine("Problem 4. Age range");
            foreach (var item in ageRange)
            {
                Console.WriteLine(item);
            }

            Students[] orderStudents = Students.OrderStudents(group10);
            Console.WriteLine();
            Console.WriteLine("Problem 5. Order students");
            foreach (var item in orderStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            List<Students> studentGroup = Students.StudentGroups(group10, 2);
            Console.WriteLine();
            Console.WriteLine("Problem 9. Student Groups");
            foreach (var item in studentGroup)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine();
            List<Students> studentEmail = Students.ExtractEmail(group10, "abv.bg");
            Console.WriteLine();
            Console.WriteLine("Problem 11. Extract email");
            foreach (var item in studentEmail)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine();
            List<Students> studentPhone = Students.FromCity(group10, "02");
            Console.WriteLine();
            Console.WriteLine("Problem 12. Extract students by phone");
            foreach (var item in studentPhone)
            {
                Console.WriteLine(item);
            }


            // Problem 13
            Console.WriteLine("Problem 13: ");

            var annonymousStudents = from student in group10
                                     where student.Marks.Contains(6)
                                     select new
                                     {
                                         FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                                         Marks = student.Marks,

                                     };

            foreach (var student in annonymousStudents)
            {
                Console.WriteLine("Full name: " + student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.WriteLine("Mark: " + mark);
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            List<Students> studentDvoiki = Students.Dvoiki(group10);
            Console.WriteLine();
            Console.WriteLine("Problem 14. S dve dvoiki");
            foreach (var item in studentDvoiki)
            {
                Console.WriteLine(item);
            }


            //Problem 15
            Console.WriteLine();


            var enrolled = from student in group10
                           where student.FN.Substring(student.FN.Length - 2) == "06"
                           select student.Marks;

            Console.WriteLine("Problem 15. Marks of students that enrolled in 2006:\n\n");

            foreach (var item in enrolled)
            {
                Console.Write("Marks are {0}, ", string.Join(", ", item));
            }
            Console.WriteLine();


            Console.WriteLine("Problem 18: ");

            var groupedStudents = from student in group10
                                  group student by student.GroupNumber into grouped
                                  from gr in grouped
                                  select gr;

            Console.WriteLine("\n\nProblem 18. Grouped by groupNumber:\n\n");

            foreach (var item in groupedStudents)
            {
                Console.WriteLine(item);
            }


           

            var groupedStudentsExtensions = group10.GroupBy(s => s.GroupNumber);

            Console.WriteLine("\n\nProblem 19:\n");

            foreach (var group in groupedStudentsExtensions)
            {
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
