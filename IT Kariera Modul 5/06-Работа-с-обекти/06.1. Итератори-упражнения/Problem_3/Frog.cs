using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROG
{
    class Frog : IEnumerable<int>
    {
        List<int> frogs = new List<int>();
        public Frog(List<int> input)
        {
            frogs = input;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < frogs.Count; i++)
            {
                if(i % 2 == 0)
                yield return frogs[i];
            }
            for(int i = frogs.Count - 1; i > 0; i--)
            {
                if(i % 2 == 1)
                yield return frogs[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
