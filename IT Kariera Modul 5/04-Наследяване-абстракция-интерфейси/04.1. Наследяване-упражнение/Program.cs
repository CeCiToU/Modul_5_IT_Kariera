using System;

namespace One_And_Two_Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
