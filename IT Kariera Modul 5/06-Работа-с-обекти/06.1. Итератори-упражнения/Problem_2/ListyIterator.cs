using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    class ListyIterator
    {
        List<string> elements;
        int index;
        public ListyIterator(params string[] elements)
        {
            index = 0;
        }

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
                Console.WriteLine($"{elements[index]}");
            }
            catch 
            {
                Console.WriteLine($"Invalid Operation!");
            }
        }

        public void Create(params string[] arr)
        {
            string[] inp = arr[0].Split().Skip(1).Where(arr => arr != "").ToArray();
            this.elements = new List<string>(inp);
        }

    }
}

