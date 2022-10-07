using System;

namespace Exercises_0
{
    class Program
    {
        static void Main(string[] args)
        {

            //input example:
            //Archy
            //3
            //Johny
            //12
            string catName = Console.ReadLine();
            int catAge = int.Parse(Console.ReadLine());
            Cat cat = new Cat(catName, catAge);
            string dogName = Console.ReadLine();
            int dogAge = int.Parse(Console.ReadLine());
            Dog dog = new Dog(dogName, dogAge);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(dog.MakeNoise());
            Console.WriteLine(dog.MakeTrick());
            Console.ResetColor();

        }
    }
}
