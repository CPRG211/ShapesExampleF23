using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample
{
    internal class Rectangle
    {
        // Constants

        // Fields
        private double width;
        private double height;
        private string color;

        // Properties
        public double Width
        {
            get { return width; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Constructor(s)
        public Rectangle(double width, double height, string color)
        {
            Width = width;

            //if (width <= 0)
            //    throw new Exception("Width cannot be zero or negative.");

            //this.width = width;
            Height = height;
            Color = color;
        }

        // Methods
        public double CalcPerimeter()
        {
            double perimeter;

            perimeter = (width * 2) + (height * 2);

            return perimeter;
        }

        public double CalcArea()
        {
            return width * height;
        }
    }
}
