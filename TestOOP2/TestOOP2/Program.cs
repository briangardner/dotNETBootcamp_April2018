using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           // BankAccount JasonAccount = new BankAccount();

            //JasonAccount.CustomerName = "Jason";
            //JasonAccount.AccountNo = "54327985723";
            //JasonAccount.Balance = 120000000;
            //JasonAccount.AccountType = "Savings account";

           // Console.WriteLine(JasonAccount.Balance);

            BankAccount Toni = 
                new BankAccount(1000,"123123131", "Saving Account","Toni");

            Toni.PrintInfo();

            

            Console.WriteLine(Toni.CustomerName+", how much you want to withdraw?");
            decimal w = decimal.Parse(Console.ReadLine());

            if (Toni.Withdraw(w))
            {
                Console.WriteLine("Please take ur money!");
            }
            else
            {
                Console.WriteLine("I will call the police in 3,2,1,...");
            }

        }
    }
}
