using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator2
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split().ToArray();
            ListyIterator<string> listy = new ListyIterator<string>();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Create":
                        List<string> inp = new List<string>();
                        for(int i = 1; i < command.Length; i++)
                        {
                            inp.Add(command[i]);
                        }
                        if (inp.Count != 0)
                        {
                            listy = new ListyIterator<string>(inp);
                        }
                        break;
                    case "Move":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(listy.Move());
                        Console.ResetColor();
                        break;
                    case "Print":
                        listy.Print();
                        break;
                    case "HasNext":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(listy.HasNext());
                        Console.ResetColor();
                        break;
                    case "PrintAll":
                        listy.PrintAll();
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
