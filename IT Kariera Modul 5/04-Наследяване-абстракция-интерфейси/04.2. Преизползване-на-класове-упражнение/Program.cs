using System;

namespace StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("str1");
            stack.Push("str2");
            stack.Push("str3");
            stack.Push("str4");
            stack.Push("str5");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());
        }
    }
}
