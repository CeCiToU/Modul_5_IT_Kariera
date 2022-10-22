using System;
using System.Collections.Generic;
using System.Linq;

namespace FROG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> frogs = Console.ReadLine().Split().Select(int.Parse).ToList();
            Frog frog = new Frog(frogs);
            var cm = frog.GetEnumerator();
            foreach(var f in frog)
            {
                Console.Write($"{f} ");
            }
            Console.WriteLine();
        }
    }
}
