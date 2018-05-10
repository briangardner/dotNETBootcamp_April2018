using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Canvas = new List<Shape>();

            Canvas.Add(new Circle(ConsoleColor.Red, 3));
            Canvas.Add(new Circle(ConsoleColor.Blue, 5));

            Canvas.Add(new Rectangle(ConsoleColor.Yellow, 3,5));

            //foreach (Shape s in Canvas)
            //    s.Draw();

            foreach (Shape s in Canvas)
            {
                s.Draw();
                Console.WriteLine(Math.Round(s.CalculateArea(),2));

            }
            // sum the areas of all shapes on the canvas 
            double sum = 0;
            foreach (Shape s in Canvas) { sum = s.CalculateArea() + sum; }
            Console.WriteLine(Math.Round(sum, 2));



        }
    }
}
