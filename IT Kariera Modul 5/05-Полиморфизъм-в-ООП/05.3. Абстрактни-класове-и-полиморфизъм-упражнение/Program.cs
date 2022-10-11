using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //double w = double.Parse(Console.ReadLine());
            //double h = double.Parse(Console.ReadLine());
            //double r  = double.Parse(Console.ReadLine());

            double w = 10;
            double h = 10;
            double r = 12;

            Shape rect = new Rectangle(w, h);
            Console.WriteLine(rect.Draw());
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.CalculatePerimeter());

            Shape cyrcle = new Cyrcle(h);
            Console.WriteLine(cyrcle.Draw());
            Console.WriteLine($"{cyrcle.CalculateArea():F2}");
            Console.WriteLine($"{cyrcle.CalculatePerimeter():F2}");
        }
    }
}
