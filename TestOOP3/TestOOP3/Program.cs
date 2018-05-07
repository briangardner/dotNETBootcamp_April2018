using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // List <type> listname = new <type>();
            // List <string> Names = new <string>();

            List<Course> courseList = new List<Course>();

            courseList.Add(new Course("C#", "Kamel Rushaidat",
                DateTime.Parse("02/01/2018"), DateTime.Parse("04/01/2018"), 12));

            courseList.Add(new Course("Java", "Antonella",
                DateTime.Parse("02/01/2018"), DateTime.Parse("04/01/2018"), 15));


            courseList.Add(new Course("JavaScript", "Adam",
                DateTime.Parse("02/01/2018"), DateTime.Parse("04/01/2018"), 20));


            // Find the average of class size

            double Sum = 0;

            for (int i = 0; i < courseList.Count; i++)
            {
                Sum = Sum + courseList[i].CourseSize;
            }

            Console.WriteLine("Avg = "+ Sum/courseList.Count);


            // Search by name: 
            Console.WriteLine("Please enter a Instructor name:");
            string name = Console.ReadLine();

            //int index = 0; 
            foreach (Course c in courseList)
            {
                if (name.ToLower() == c.InstructorName.ToLower())
                {
                    Console.WriteLine(c.CourseName);
                }
              //  index++; 
            }

            // LINQ 


        }
    }
}
