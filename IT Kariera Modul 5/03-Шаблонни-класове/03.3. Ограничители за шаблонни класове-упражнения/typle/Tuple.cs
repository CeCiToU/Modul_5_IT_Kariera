using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuple
{
    class Tuple<T,V>
    {
        T item1;
        V item2;

        public Tuple(T element1, V element2)
        {
            item1 = element1;
            item2 = element2;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
