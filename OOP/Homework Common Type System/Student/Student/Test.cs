namespace Student
{
    using System;

    public class Test
    {
        static void Main()
        {

            var firstStudent = new Student("Ivaylo", "Ivayloev", "Ivayloev", 666589745, "ul. Starata Reka 9", "0889011207", "tito.iliev@gmail.com", 2, Specialty.Mathematics, University.SoftUni, Faculty.EEP);

            var secondStudent = new Student("Ivaylo", "Ivayloev", "Ivayloev", 666589745, "ul. Starata Reka 9", "0889011207", "tito.iliev@gmail.com", 2, Specialty.Mathematics, University.SoftUni, Faculty.EEP);

            var thirdStudent = new Student("Ivaylo", "Ivayloev", "Ivayloev", 111111111, "ul. Starata Reka 9", "0889011207", "tito.iliev@gmail.com", 2, Specialty.Mathematics, University.SoftUni, Faculty.EEP);

            var fourthStudent = new Student("Ivaylo", "Ivayloev", "Ivayloev", 1111111110, "ul. Starata Reka 9", "0889011207", "tito.iliev@gmail.com", 2, Specialty.Mathematics, University.SoftUni, Faculty.EEP);


            var cloneStudent = (Student)firstStudent.Clone();

            Console.WriteLine(firstStudent);
            Console.WriteLine();
            Console.WriteLine(cloneStudent);
            Console.WriteLine(thirdStudent.CompareTo(fourthStudent));
        }
    }
}
