using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try // if 
            {
                // Input
                Console.WriteLine("Please enter a number");
                int Input1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                int Input2 = int.Parse(Console.ReadLine());

                // processing
                int result = Input1 / Input2;

                // output 
                Console.WriteLine(result);
            }
            catch (FormatException)// else if 
            {
                Console.WriteLine("I think you entered bad input!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("I think you are dividing on zero!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("I think you did enter a big number!");

            }
            catch (Exception)// else 
            {
                Console.WriteLine("I think you are trying to do something bad! Nice try. ");

            }
        }
    }
}
