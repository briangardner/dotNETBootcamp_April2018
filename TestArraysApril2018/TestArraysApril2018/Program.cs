using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArraysApril2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] EmployeeAges = new int[10];


            int[] EmployeeAges; // Declare step 
            EmployeeAges = new int[4]; // initialize step

            //for (int i = 0; i < EmployeeAges.Length; i++)
            //{
            //    Console.WriteLine(EmployeeAges[i]);
            //}

            // Get the user to enter the values for the elements 
            for (int i = 0; i < EmployeeAges.Length; i++)
            {
                Console.WriteLine($"Please enter an Age of Employee No.{i+1}");
                int Input = int.Parse(Console.ReadLine());
                EmployeeAges[i] = Input; 
            }


            // processing 
            // 1. Avg 
            // 2. Min, Max


            // Avg: Sum then divide on Length 

            float Sum = 0;

            for (int i = 0; i < EmployeeAges.Length; i++)
            {
                Sum = Sum + EmployeeAges[i];
            }

            // Find Avg: 

            // output step 
            float Avg = Sum / EmployeeAges.Length;

            Console.WriteLine(Avg);



           

        }
    }
}
