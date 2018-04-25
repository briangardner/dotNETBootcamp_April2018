using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Am I Hungry?");
            string Choice1 = Console.ReadLine();

            if (Choice1.ToLower() == "yes")
            {
                Console.WriteLine("Have I $25?");
                string Choice2 = Console.ReadLine();
                if (Choice2.ToLower() == "yes")
                {
                    Console.WriteLine("Go to Subway!");
                }
                else
                {
                    Console.WriteLine("Buy a burger!");
                }

            } // go to line 37  

            else
            {
                Console.WriteLine("Go to sleep!");

            }




        }
    }
}
