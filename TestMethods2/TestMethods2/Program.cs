using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // do this for user input 
            int As = CountAs("Grand Circus Detroit");
            Console.WriteLine(As);
        }


        public static int CountAs(string Input)
        {
            int Count = 0;
            for (int i = 0; i < Input.Length;i++)
            {
                if (Input[i] == 'a' || Input[i] == 'A')
                    Count = Count + 1;

            }
            return Count; 

        }
    }
}
