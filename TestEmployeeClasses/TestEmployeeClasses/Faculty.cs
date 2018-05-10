using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployeeClasses
{
    class Faculty : Employee
    {
        private decimal baseSalary;
        private decimal bonus; 
        public decimal BaseSalary
        {
            set { baseSalary = value; }
            get { return baseSalary; }
        }
        public decimal Bonus
        {
            set { bonus = value; }
            get { return bonus; }
        }
        public Faculty()
        {
            Address = "5057 Woodward Ave.";
        }

        public Faculty(string i, string n, string s, string a, decimal baseSal, decimal _bonus):base(i,n,s,a)
        {

            Bonus = _bonus;
            BaseSalary = baseSal; 

        }

        public override decimal CalculateSalary()
        {
            return Bonus + BaseSalary;
        }
    }
}
