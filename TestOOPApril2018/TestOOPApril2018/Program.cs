using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPApril2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Mike = new Student();
            Mike.Name = "Mike Yalda"; // set 
            Console.WriteLine(Mike.Name); // get 

            Mike.HomeTown = "Troy";
            Mike.FavFood = "Pizza";
            Mike.DateOfBirth = DateTime.Parse("01/01/2005");

            Mike.PrintInfo();

           



        }
    }
}
