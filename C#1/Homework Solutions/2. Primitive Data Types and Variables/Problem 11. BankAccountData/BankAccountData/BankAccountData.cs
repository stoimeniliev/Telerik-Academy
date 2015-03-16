using System;
/*
 Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string fName = "Stoimen";
            string mName = "Boyanov";
            string lName = "Iliev";
            byte ballance = 70;
            string bankName = "First Investment Bank";
            string IBAN = "BG07FINV91501215999954";
            long[] creditCards = { 378282246310005, 371449635398431, 378734493671000 };
        }
    }
}
