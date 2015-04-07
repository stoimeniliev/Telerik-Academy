﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Loans : Accounts
    {

        private CustomersEnum customerType;
        private double deposit;
        private double numbers_of_months;
        private double interest_rate = 0.08;

        public Loans(CustomersEnum customerType, double deposit, double numbers_of_months)
            : base(customerType, deposit, numbers_of_months)
        {
            this.EnumCustomers = customerType;
            this.Deposit = deposit;
            this.NumbersOfMonths = numbers_of_months;
        }
        public double Interest()
        {

            if (customerType == CustomersEnum.individual)
            {
                if (numbers_of_months <= 3)
                {
                    return 0;
                }
                else
                {
                    return (deposit * (numbers_of_months - 3) * interest_rate) - deposit;
                }
            }
            else
            {
                if (numbers_of_months <= 2)
                {
                    return 0;
                }
                else
                {
                    return deposit + (deposit * (numbers_of_months - 2) * interest_rate) - deposit;
                }

            }
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
        public override string ToString()
        {
            StringBuilder printAccount = new StringBuilder();
            printAccount.Append(this.Interest());
            return printAccount.ToString();
        }

    }
}

