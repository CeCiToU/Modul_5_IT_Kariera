using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //int r = int.Parse(Console.ReadLine());
            //int w = int.Parse(Console.ReadLine());
            //int h = int.Parse(Console.ReadLine());

            //int r = 25;
            //int w = 14;
            //int h = 25;

            //Circle circ = new Circle(r);
            //circ.Draw();

            //Console.WriteLine();

            //Rectangle rect = new Rectangle(w,h);
            //rect.Draw();


            Seat seat = new Seat("Leon", "Grey");
            Tesla tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());



        }
    }
}
