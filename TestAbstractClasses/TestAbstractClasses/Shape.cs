using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    abstract class Shape
    {
        // data member 
        // color : string? 
        // enums 
        private ConsoleColor shapeColor;
        public ConsoleColor ShapeColor
        {
            set { shapeColor = value; }
            get { return shapeColor; }
        }
        public Shape()
        {
        }
        public Shape(ConsoleColor c)
        {
            ShapeColor = c;
        }
        public abstract void Draw();
        public abstract double CalculateArea();
    }
}
