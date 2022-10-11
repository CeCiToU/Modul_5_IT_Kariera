using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Shape
    {
        abstract public double CalculatePerimeter();
        abstract public double CalculateArea();

        abstract public string Draw();
       
    }
}
