using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Customer
    {
        private string name;
        CustomersEnum customerType;

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
                    throw new ArgumentNullException("Invalid name!");
                }
                this.name = value;
            }
        }

        public Customer(string inputName, CustomersEnum inputCustomerType)
        {
            this.Name = inputName;
            this.CustomerType = inputCustomerType;
        }

        public CustomersEnum CustomerType
        {
            get
            {
                return this.customerType;
            }
            private set
            {
                this.customerType = value;
            }
        }

        public override string ToString()
        {
            return this.CustomerType + ", " + this.Name;
        }

    }
}
