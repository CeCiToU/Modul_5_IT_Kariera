using System;
using System.Linq;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carArr = Console.ReadLine().Split().ToArray();
            string[] truckArr = Console.ReadLine().Split().ToArray();

            Car car = new Car(double.Parse(carArr[1]), double.Parse(carArr[2]));
            Truck truck = new Truck(double.Parse(truckArr[1]), double.Parse(truckArr[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArr = Console.ReadLine().Split().ToArray();
                switch (commandArr[0])
                {
                    case "Drive":
                        if (commandArr[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(double.Parse(commandArr[2])));
                        }
                        else
                        {
                            Console.WriteLine(truck.Drive(double.Parse(commandArr[2])));
                        }
                        break;
                    case "Refuel":
                        if (commandArr[1] == "Car")
                        {
                            car.Refuel(double.Parse(commandArr[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(commandArr[2]));
                        }
                        break;
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }
    }
}
