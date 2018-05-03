using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design an application that
            //will be used to take orders (strings)

            //1. Create the list (empty)
            List<string> OrderList = new List<string>();

            //2. Take input and add it to the list (done multiple times)



            while (true)
            {
                Console.WriteLine("Please enter an order:");
                string UserOrder = Console.ReadLine();
                OrderList.Add(UserOrder);// adds the Input to the list 

                Console.WriteLine("Do you want to continue?");
                string Choice = Console.ReadLine();
                if (Choice == "n")
                {
                    break;
                }

            }

            //3. Print the list 
            //for (int i = 0; i < OrderList.Count; i++)
            //{
            //    Console.WriteLine(OrderList[i]);
            //}

            foreach (string element in OrderList)
            {
                Console.WriteLine(element);
            }


        }
    }
}
