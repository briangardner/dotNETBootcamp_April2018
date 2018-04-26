using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder MyString = new StringBuilder("Hello World");

            MyString.Insert(5, " from ");

            Console.WriteLine(MyString);

            // GC.Collect();

            Console.WriteLine('\u2103');
        }
    }
}
