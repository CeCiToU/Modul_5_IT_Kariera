using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuel, double fuelNeed) : base(fuel, fuelNeed + 0.9)
        {
        }

        public override string Drive(double distance)
        {
            return "Car" + base.Drive(distance);
        }

        public override string ToString()
        {
            return "Car: " + base.ToString();
        }
    }
}
