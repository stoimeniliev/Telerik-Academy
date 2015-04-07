using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Bank
    {
        private string name;
        private Dictionary<Customer, Accounts> customerAccounts = new Dictionary<Customer, Accounts>();


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentNullException("Invalid bank name!");
                }
                this.name = value;
            }
        }

        private Dictionary<Customer, Accounts> CustomerAccounts
        {
            get
            {
                return this.customerAccounts;
            }
            set
            {
                this.customerAccounts = value;
            }
        }

        public Bank(string inputName)
        {
            this.Name = inputName;
        }

        public void AddNewCustomer(Customer inputCustomer)
        {
            CustomerAccounts.Add(inputCustomer, null);
        }

        public void AddAccountToCustomer(Customer inputCustomer, Accounts inputListOfAccounts)
        {
            CustomerAccounts[inputCustomer] = inputListOfAccounts;
        }



        public override string ToString()
        {
            StringBuilder printInfo = new StringBuilder();

            foreach (var customer in this.CustomerAccounts.Keys)
            {
                printInfo.AppendLine(customer.ToString());

                printInfo.AppendLine(this.CustomerAccounts[customer].ToString());

                printInfo.AppendLine(new String('-', 20));
            }



            return printInfo.ToString();
        }

    }
}
