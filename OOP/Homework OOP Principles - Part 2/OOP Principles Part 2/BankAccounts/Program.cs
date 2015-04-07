using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer firstCustomer = new Customer("Stoimen Iliev", CustomersEnum.individual);
            Customer secondCustomer = new Customer("Telerik", CustomersEnum.companies);
            Customer thirdCustomer = new Customer("Ivaylo Kenov", CustomersEnum.individual);

            Accounts depositFirst = new Deposits( CustomersEnum.individual, 1236.36, 36);
            Accounts depositSecond = new Deposits(CustomersEnum.individual, 1222, 32);
            Accounts loanSecond = new Loans(CustomersEnum.companies, 12365, 45);

            Bank secureBank = new Bank("Gotham Bank");

            secureBank.AddNewCustomer(firstCustomer);
            secureBank.AddNewCustomer(secondCustomer);
            secureBank.AddNewCustomer(thirdCustomer);

            secureBank.AddAccountToCustomer(firstCustomer, depositFirst);
            secureBank.AddAccountToCustomer(secondCustomer, depositSecond);
            secureBank.AddAccountToCustomer(thirdCustomer, loanSecond);

            Console.WriteLine(secureBank);

        }
    }
}
