using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    class Circle : Shape
    {
        private double radius; 

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }
        public Circle()
        {
        }
        public Circle(ConsoleColor c, double r):base(c)
        {
            Radius = r; 
        }

        public override void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            Console.WriteLine("Hey, I am a circle");
            Console.ForegroundColor = ConsoleColor.White; // reset 
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
