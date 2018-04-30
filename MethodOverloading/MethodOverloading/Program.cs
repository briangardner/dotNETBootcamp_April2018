using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMessages("Hello");

            //PrintMessages("Hi",10);

            FailedMethod();

            Math.Abs(Math.Ceiling(-3.2));

            

        }

            static void PrintMessages(string message)
            {
                Console.WriteLine(message);

            }
            static void PrintMessages(string message, int numberofTimes)
            {
                for (int i = 1; i <= numberofTimes; i++)
                {
                    Console.WriteLine(message);
                }
            }


            static void FailedMethod()
            {

                FailedMethod();

            }
        
    }
}
