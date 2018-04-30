using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation on the user's input to check for valid
            // SSN

            // input 

            //string Input = Console.ReadLine();

            //if (Regex.IsMatch(Input, @"^\d{3}-\d{2}-\d{4}$|^\d{9}$"))
            //{
            //    Console.WriteLine("I got your SSN!!!");

            //}
            //else
            //{
            //    Console.WriteLine("Not a valid SSN!");
            //}

            string Input = Console.ReadLine();

            while (! Regex.IsMatch(Input, @"^\d{3}-\d{2}-\d{4}$|^\d{9}$"))
            {
                Console.WriteLine("Invalid SSN!");

                Input = Console.ReadLine();
            }
            

        }
    }
}
