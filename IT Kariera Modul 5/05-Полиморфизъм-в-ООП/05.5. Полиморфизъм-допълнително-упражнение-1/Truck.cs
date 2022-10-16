using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuel, double fuelNeed) : base(fuel, fuelNeed + 1.6)
        {
        }

        public override string Drive(double distance)
        {
            return "Truck" + base.Drive(distance);
        }

        public override void Refuel(double amount)
        {
            amount = (amount * 95)/ 100;
            base.Refuel(amount);
        }

        public override string ToString()
        {
            return "Truck: " + base.ToString();
        }
    }
}
