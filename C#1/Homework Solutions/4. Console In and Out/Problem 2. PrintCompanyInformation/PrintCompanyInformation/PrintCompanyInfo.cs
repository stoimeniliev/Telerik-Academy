using System;
/*
 Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager 
 * and prints it back on the console.
 */

namespace PrintCompanyInformation
{
    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Company phone number: ");
            string companyPhone = Console.ReadLine();
            Console.WriteLine("Company fax: ");
            string companyFax = Console.ReadLine();       
            Console.WriteLine("Company web address: ");
            string companyWebsite = Console.ReadLine();
            Console.WriteLine("Company manager first name: ");
            string companyManagerF = Console.ReadLine();
            Console.WriteLine("Company managager last name: ");
            string companyManagerL = Console.ReadLine();
            Console.WriteLine("Company manager's age: ");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Company manager's phone: ");
            string managerPhone = Console.ReadLine();

            if (String.IsNullOrEmpty(companyName))
                Console.WriteLine("No company name");
            else
                Console.WriteLine(companyName);

            if (String.IsNullOrEmpty(companyAddress))
                Console.WriteLine("Address: (no address)");
            else
                Console.WriteLine("Address: " + companyAddress);

            if (String.IsNullOrEmpty(companyPhone))
                Console.WriteLine("Tel. (no tel.)");
            else
                Console.WriteLine("Tel. " + companyPhone);

            if (String.IsNullOrEmpty(companyFax))
                Console.WriteLine("Fax: (no fax)");
            else
                Console.WriteLine("Fax " + companyFax);

            if (String.IsNullOrEmpty(companyWebsite))
                Console.WriteLine("Web site: (no web site)");
            else
                Console.WriteLine("Web site: " + companyWebsite);


            if (String.IsNullOrEmpty(companyManagerF))
                companyManagerF = "(no first name)";
            if (String.IsNullOrEmpty(companyManagerL));
                companyManagerL = "(no last name)";
            if (String.IsNullOrEmpty(managerAge));
                managerAge = "(not known)";
            if (String.IsNullOrEmpty(managerPhone));
                managerPhone = "(not known)";

            Console.WriteLine(companyManagerF + " " + companyManagerL + "(age: {0}, tel. {1}", managerAge, managerPhone);
            Console.ReadLine();
        }
    }
}
