using System;
using System.Linq;

namespace tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            string[] arr3 = Console.ReadLine().Split().ToArray();

            Tuple<string, string> firstTuple = new Tuple<string, string>(arr1[0] + " " + arr1[1], arr1[2]);
            Tuple<string, int> secondTuple = new Tuple<string, int>(arr2[0], int.Parse(arr2[1]));
            Tuple<int, double> thirdTuple = new Tuple<int, double>(int.Parse(arr3[0]), double.Parse(arr3[1]));
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
