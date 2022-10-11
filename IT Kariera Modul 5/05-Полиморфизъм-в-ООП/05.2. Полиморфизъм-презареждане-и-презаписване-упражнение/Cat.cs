using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Animal
    {
        public Cat(string name, string food) : base(name, food)
        {

        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + $"\nMEEOW";
        }
    }
}
