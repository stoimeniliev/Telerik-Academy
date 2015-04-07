using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    abstract class Accounts
    {

        private CustomersEnum customerType;
        private double deposit;
        private double numbers_of_months;
        

        public Accounts(CustomersEnum customerType, double deposit, double numbers_of_months)
        {
            this.EnumCustomers = customerType;
            this.Deposit = deposit;
            this.NumbersOfMonths = numbers_of_months;
        }
        public CustomersEnum EnumCustomers
        {
            get
            {
                return this.customerType;
            }
            set
            {
               

                this.customerType = value;
            }
        }
        public double Deposit
        {
            get
            {
                return this.deposit;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Value must be positive!");
                }

                this.deposit = value;
            }
        }

        public double NumbersOfMonths
        {
            get
            {
                return this.numbers_of_months;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Value must be positive!");
                }

                this.numbers_of_months = value;
            }
        }

        
        

    }
}
