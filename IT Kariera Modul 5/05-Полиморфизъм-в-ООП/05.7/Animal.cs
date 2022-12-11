using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
    abstract class Animal
    {
        private string animalName;
        private string animaltype;
        private double animalWeight;
        private int foodEaten;


        public abstract void makeSound();
        public void Eat(int food) 
        {
            foodEaten =- food;
        }
    }
}
