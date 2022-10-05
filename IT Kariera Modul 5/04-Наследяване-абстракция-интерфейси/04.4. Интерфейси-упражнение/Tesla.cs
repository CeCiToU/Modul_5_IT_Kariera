using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int batteries;
        public Tesla(string model, string color, int batteries)
        {
            this.model = model;
            this.color = color;
            this.batteries = batteries;
        }

        public int Battery()
        {
            return this.batteries;
        }

        public string Color()
        {
            return this.color;
        }

        public string Model()
        {
            return this.model;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color()} Tesla {this.Model()} with {this.Battery()} Batteries\n{this.Start()}\n{this.Stop()}";
        }
    }
}
