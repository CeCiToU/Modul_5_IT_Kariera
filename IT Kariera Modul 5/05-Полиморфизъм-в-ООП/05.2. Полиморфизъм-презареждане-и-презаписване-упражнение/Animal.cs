using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string food)
        {
            this.name = name;
            this.favouriteFood = food;
        }

        public virtual string ExplainMyself()
        {
            return $"I am {name} and my favourite food is {favouriteFood}";
        }
    }
}
