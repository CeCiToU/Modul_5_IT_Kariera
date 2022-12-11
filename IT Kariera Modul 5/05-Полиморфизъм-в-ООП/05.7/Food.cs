using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
    abstract class Food
    {
        private int quantity;

        public Food()
        {

        }

        public Food(int q)
        {
            Quantity = q;
        }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
