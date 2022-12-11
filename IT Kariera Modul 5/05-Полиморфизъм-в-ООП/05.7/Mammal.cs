using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
    class Mammal : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
