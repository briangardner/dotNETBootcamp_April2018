using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays2April2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design a program that reads the number of students
            // then creates an array of type double
            // The program will read the grades for students
            // then find the max and min grade 

            // 1. Read the number of students and save it in a variable
            Console.WriteLine("Please enter the amount of students");
            int amtStudents = int.Parse(Console.ReadLine());

            // 2. Create an array of type double with the size amtStudents
            double[] Students = new double[amtStudents];

            // 3. Ask the user to enter the grades (Input step)
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Please enter a grade for student No.{i + 1}");
                double input = double.Parse(Console.ReadLine());
                Students[i] = input;
;            }
        }
    }
}
