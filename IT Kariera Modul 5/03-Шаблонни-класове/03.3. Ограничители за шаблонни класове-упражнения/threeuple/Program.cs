using System;
using System.Linq;

namespace threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            string[] arr3 = Console.ReadLine().Split().ToArray();

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string,string>(arr1[0] + " " + arr1[1], arr1[2], arr1[3]);
            Threeuple<string, int, string> secondTuple = new Threeuple<string, int, string >(arr2[0], int.Parse(arr2[1]), arr2[2]);
            Threeuple< string, double, string> thirdTuple = new Threeuple<string, double, string>(arr3[0], double.Parse(arr3[1]), arr3[2]);
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
