using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeuple
{
    class Threeuple<T,V,P>
    {
        T item1;
        V item2;
        P item3;

        public Threeuple(T element1, V element2, P element3)
        {
            item1 = element1;
            item2 = element2;
            item3 = element3;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
