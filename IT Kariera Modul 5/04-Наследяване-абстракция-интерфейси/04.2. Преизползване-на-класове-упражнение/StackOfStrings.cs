using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class StackOfStrings
    {
        private List<string> data = new List<string>();

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            string element = data.Last();
            data.RemoveAt(data.Count - 1);
            return element;
        }

        public string Peek()
        {
            return data[0];
        }

        public bool IsEmpty()
        {
            if(data[0] != null)
            {
                return false;
            }
            return true;
        }
    }
}
