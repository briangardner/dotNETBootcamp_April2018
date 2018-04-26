using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // build a program that asks the user to enter two integers
            // and then the program will find the largest of those two numbers

            // Input 
            int Input1 = ReadIntegers("Please give me a number");
            int Input2 = ReadIntegers("Please one more number");

            // processing
            int Max;
            Max = FindMax(Input1,Input2);

            // output 
            Console.WriteLine(Max);
        }

        public static int ReadIntegers(string Message)
        {
            Console.WriteLine(Message);
            int Input = int.Parse(Console.ReadLine());
            return Input; 
        }

        public static int FindMax(int Input1, int Input2)
        {
            // processing
            int Max;
            if (Input1 > Input2)
                Max = Input1;
            else
                Max = Input2;

            return Max; 

        }

    }
}
