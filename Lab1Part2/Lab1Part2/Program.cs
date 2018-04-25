using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate your sales taxes 
            // 1. Input 
            Console.WriteLine("Please enter the amount:");
            decimal Amount = decimal.Parse(Console.ReadLine());
            decimal Result = 0;

            // validation 

            // 2. Processing 
            // if the amount is less than $50, then there is no tax applied 
            // else: apply 6% tax 
            if (Amount >= 50)
            {
                Result = Amount * 0.06m; 
            }

            //3. Output 
            Console.WriteLine(Result);


        }
    }
}
