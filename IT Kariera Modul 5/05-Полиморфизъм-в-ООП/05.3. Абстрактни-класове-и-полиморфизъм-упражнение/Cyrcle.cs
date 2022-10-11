using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Cyrcle : Shape
    {
        private double radius;
        public Cyrcle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perinmeter = 2 * Math.PI * Radius;
            return perinmeter;
        }

        public override string Draw()
        {
            string str = "";
            double r_in = this.Radius - 0.4;
            double r_out = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += " ";
                    }
                }
                str += "\n";

            }
            return str;
        }
    }
}
