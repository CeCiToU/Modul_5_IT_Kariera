using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator2
{
    class ListyIterator<T> : IEnumerable<T>
    {
        List<T> elements;
        int index;
        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            index = 0;
        }

        public ListyIterator() : this(new List<T>()){}

        public bool Move()
        {
            if (index + 1 < elements.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index + 1 < elements.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{elements[index]}");
                Console.ResetColor();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid Operation!");
                Console.ResetColor();
            }
        }

        public void PrintAll()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{elements[i]} ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
