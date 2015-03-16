using System;
/*
 Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
 */

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Stoimen";
            string lastName = "Iliev";
            byte age = 24;
            char gender = 'm';
            long personalId = 8306112507;
            int employeeNumber = 27560000;
            Console.WriteLine("First name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nEmployee Id: {4}\nEmployee Number: {5}", firstName, lastName, age, gender, personalId, employeeNumber);


        }
    }
}
