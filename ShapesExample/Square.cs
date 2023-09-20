using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExample
{
    internal sealed class Square : Rectangle
    {
        public double Side
        {
            get { return Width; }
            set
            {
                Width = value;
                Height = value;
            }
        }

        //public new double Width
        //{
        //    get
        //    {
        //        return Width;
        //    }
        //    set
        //    {
        //        Width = value;
        //        Height = value;
        //    }

        //}

        //public new double Height
        //{
        //    get
        //    {
        //        return Side;
        //    }
        //    set
        //    {
        //        Width = value;
        //        Height = value;
        //    }

        //}

        public Square(double side, string color) : base(side, side, color)
        {
        }
    }
}
