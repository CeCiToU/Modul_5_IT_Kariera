using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparer_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string[] command;
            while((command = Console.ReadLine().Split().ToArray())[0] != "END")
            {
                Person currentPerson = new Person(command[0],int.Parse(command[1]), command[2]);
                persons.Add(currentPerson);
            }
            int n = int.Parse(Console.ReadLine());
            int equal = 0;
            int nonEqual = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[n - 1].CompareTo(persons[i]) == 0)
                {
                    equal++;
                }
                else
                {
                    nonEqual++;
                }
            }
            if (equal == 1)
            {
                Console.WriteLine("No matches!");
            }
            else
            {
                Console.WriteLine($"{equal} {nonEqual} {persons.Count}");
            }
        }
    }
}
