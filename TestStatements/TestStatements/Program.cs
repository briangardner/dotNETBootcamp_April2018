using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please enter age");

            //int Age = int.Parse(Console.ReadLine());

            //if ((Age>=0) && (Age <=125))
            //{
            //    Console.WriteLine("Not a valid Age!!!!");

            //}

            Console.WriteLine("Please enter grade");
            double Grade = double.Parse(Console.ReadLine());

            //if (Grade >= 90 && Grade <= 100)
            //    Console.WriteLine("A");
            //else if (Grade >= 87 && Grade <= 89)
            //    Console.WriteLine("A-");
            //else if (Grade >= 84 && Grade <= 86)
            //    Console.WriteLine("B+");
            //else
            //    Console.WriteLine("F");


            if (Grade >= 90)
            { Console.WriteLine("A"); }
            else if (Grade >= 87)
            { Console.WriteLine("A-"); }
            else if (Grade >= 84)
            { Console.WriteLine("B+"); }
            else
            { Console.WriteLine("F"); }



        }
    }
}
