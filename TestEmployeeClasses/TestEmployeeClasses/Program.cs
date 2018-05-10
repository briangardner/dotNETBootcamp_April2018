using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployeeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty Jasmine = new Faculty("1234", "Jasmine", "123456787", "1570 Wayne Rd", 3000, 2000);

            Employee James = new Employee("2345", "James", "432453245", "1570 woodward ave.");

            Console.WriteLine(Jasmine.CalculateSalary());

           


        }
    }
}
