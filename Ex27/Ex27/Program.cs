using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "HelloWorld";

            string str = str1.ToLower();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'a' && str[i] != 'e'
                    && str[i] != 'i' && str[i] != 'o' && str[i] != 'u')
                    count = count + 1;
            }
            Console.WriteLine(count);


            ///////////////////////////////////////////////////////////



            //string Vowels = "aeiuo";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!Vowels.Contains(str[i]))
            //        count++;
            //}

           // Console.WriteLine(count);



        }
    }
}
