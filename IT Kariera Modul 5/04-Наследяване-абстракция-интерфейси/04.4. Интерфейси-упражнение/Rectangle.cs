using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public void Draw()
        {
            FirstAndLastRow(width);
            MiddleRows(width,height);
            FirstAndLastRow(width);
        }

        private void MiddleRows(int width, int height)
        {
            for (int i = 1; i < height - 1; i++)
            {
                Console.WriteLine("*" + new string(' ', width - 2) + "*");
            }
        }
        private void FirstAndLastRow(int width)
        {
            Console.WriteLine(new string('*', width));
        }

    }
}
