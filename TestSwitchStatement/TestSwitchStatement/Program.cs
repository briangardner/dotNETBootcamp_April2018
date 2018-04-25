using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch;
            bool UserContinue = true; 
            while (UserContinue == true)
            {
                Console.Clear();
                // print the users selections 
                Console.WriteLine("Welcome to GC burgers! Select an option");
                Console.WriteLine("1. Cheese Burger");
                Console.WriteLine("2. Coke");
                Console.WriteLine("3. Veggie Burger");
                Console.WriteLine("4. Exit");

                // print the users selections 
                caseSwitch = int.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Cheese Burger");
                        Console.WriteLine("Do you want Cheese on your burger?");
                        string Choice = Console.ReadLine();
                        if (Choice.ToLower() == "yes")
                        {
                            Console.WriteLine("You got it!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Coke");
                        break;
                    case 3:
                        Console.WriteLine("Veggie Burger");
                        break;
                    default:
                        UserContinue = false; 
                        Console.WriteLine("Why did you even come here?");
                        break;
                }
            }


        }
    }
}
