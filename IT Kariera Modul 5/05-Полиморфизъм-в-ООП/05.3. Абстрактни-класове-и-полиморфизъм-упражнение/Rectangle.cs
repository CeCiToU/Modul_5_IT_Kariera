using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public override double CalculateArea()
        {
            double area = Width * Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Width + 2 * Height;
            return perimeter;
        }

        public override string Draw()
        {
            string str = "";
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    str += "*";
                }
                str += "\n";
            }
            return str;
        }
    }
}
