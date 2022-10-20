using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();
            ListyIterator list = new ListyIterator();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Create":
                        list.Create(string.Join(" ", command));
                        break;
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        list.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
