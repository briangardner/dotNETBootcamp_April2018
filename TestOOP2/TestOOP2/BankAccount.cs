using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    class BankAccount
    {
        #region data members 
        private decimal balance;
        private string customerName;
        private string accountNo;
        private string accountType;
        #endregion

        #region properties
        public decimal Balance
        {
            //set
            //{
            //    balance = value;
            //}
            get
            {
                return balance;
            }
        }
        public string CustomerName
        {
            set
            {
                customerName = value;
            }
            get
            {
                return customerName;
            }
        }

        public string AccountNo
        {
            set
            {
                accountNo = value;
            }
            get
            {
                return accountNo;
            }
        }

        public string AccountType
        {
            set
            {
                accountType = value;
            }
            get
            {
                return accountType;
            }
        }



        //public string AccountNo { get => accountNo; set => accountNo = value; }

        //public string AccountType
        //{
        //    set; get; 
        //}
        #endregion

        #region Constructors
        // default constructor 
        public BankAccount()
        {
            balance = 100;
            AccountType = "Checking Account";
        }

        // overloaded constructor 
        public BankAccount(decimal b, string acctNo, string accType, string name)
        {   // property name on the left side 
            balance = b;
            AccountNo = acctNo;
            AccountType = accType;
            CustomerName = name; 

        }
        #endregion

        #region Methods
        public void PrintInfo()
        {
            Console.WriteLine("Customer Name: "+CustomerName);
            Console.WriteLine("Balance: "+ Balance);
            Console.WriteLine("Account Type: "+ AccountType);
            Console.WriteLine("Account No. "+ AccountNo);
        }

        public bool Withdraw(decimal w)
        {
            if (w <= balance)
            {
                balance -= w;
                return true;
            }
            else
            {
                return false; 
            }

        }
        #endregion
    }
}
