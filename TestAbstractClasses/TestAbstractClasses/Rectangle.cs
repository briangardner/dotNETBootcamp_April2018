using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    class Rectangle : Shape
    {  
        public double Length { set; get; }
        public double Width { set; get; }

        public Rectangle()
        {
        }
        public Rectangle(ConsoleColor c, double len, double w):base(c)
        {
            Length = len;
            Width = w; 

        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            Console.WriteLine("Dude, I am a Rectangle");
            Console.ForegroundColor = ConsoleColor.White; // reset 
        }
    }
}
