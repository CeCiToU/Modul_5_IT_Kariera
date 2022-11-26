using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func
            //Func<string, int> func = n => int.Parse(n);
            //int num = func("123");
            //Console.WriteLine(num);

            //Action
            //List<string> names = new List<string> { "Pesho", "Gosho", "Kiro" };
            //Action<string> cw = n => Console.WriteLine(n);
            //names.ForEach(cw);

            //Predicate
            //Predicate<string> predicate = s => s.Length == 2;
            //List<string> str = new List<string> { "ab", "abc", "bc", "def", "ef" };
            //str.RemoveAll(predicate);
            //Console.WriteLine(string.Join(" ", str));


            Dictionary<string, int> people = new Dictionary<string, int>();
            Func<int, bool> checker = n => n >= 20;
            for(int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                if (checker(age))
                {
                    people.Add(name, age);
                }
            }
            foreach(var guy in people)
            {
                Console.WriteLine(guy.Key + " " + guy.Value);
            }
            
            
        }
    }
}
