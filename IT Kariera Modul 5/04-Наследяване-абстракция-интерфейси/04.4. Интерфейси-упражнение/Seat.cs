﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Seat : ICar
    {
        private string model;
        private string color;
        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
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
            return $"{this.Color()} Seat {this.Model()}\n{this.Start()}\n{this.Stop()}";
        }
    }
}
