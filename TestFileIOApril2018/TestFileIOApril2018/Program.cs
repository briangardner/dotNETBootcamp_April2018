using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileIOApril2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the names into a list of strings 
            // StreamReader 

            // read the file one line at a time
            List<string> Names = new List<string>();
            ReadFile(Names);

            foreach (string name in Names)
                Console.WriteLine(name);


            // write to the file 
            StreamWriter wr = new StreamWriter("../../StudentNames.txt");// true is to enable append
            wr.WriteLine("Kim");
            wr.Close();


            



        }

        private static void ReadFile(List<string> Names)
        {
            StreamReader reader = new StreamReader("../../StudentNames.txt");
            string line = reader.ReadLine(); // read a line 
            while (line != null)
            {
                Names.Add(line); // add the name to the list
                // keep reading 
                line = reader.ReadLine();
            }
            reader.Close();// close the file 
        }
    }
}
