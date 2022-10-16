using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class Vehicle
    {

        public Vehicle(double fuel, double fuelNeed)
        {
            FuelAmount = fuel;
            FuelNeed = fuelNeed;
        }
        double fuelAmount;
        double fuelNeed;

        public virtual string Drive(double distance)
        {
            double possibleDrive = FuelAmount / FuelNeed;
            if(possibleDrive < distance)
            {
                return $" needs refueling!";
            }
            else
            {
                double currentNeed = distance * FuelNeed;
                FuelAmount -= currentNeed;
                return $" travelled {distance} km";
            }
        }

        public virtual void Refuel(double amount)
        {
            FuelAmount += amount;
        }

        public override string ToString()
        {
            return $"{FuelAmount:F2}";
        }

        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelNeed { get => fuelNeed; set => fuelNeed = value; }
    }
}
