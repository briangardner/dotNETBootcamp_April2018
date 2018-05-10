using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployeeClasses
{
    class Employee
    {
        private string id;
        private string name;
        private string ssn;
        private string address; 

        public string ID
        {
            set; get; 
        }

        public string Name
        {
            set; get; 

        }

        public string SSN
        {
            set; get;
        }

        public string Address
        {
            set; get; 
        }

        public Employee()
        {
            Address = "1570 Woodward Ave., Detroit, MI, 48202";
        }

        public Employee(string i, string n, string s, string a)
        {
            ID = i;
            Name = n;
            SSN = s;
            Address = a; 
        }

        // method 
        public virtual decimal CalculateSalary()
        {
            return 10; 
        }
    }
}
