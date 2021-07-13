using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericClass
    {
        int a;
        int b;

        public GenericClass(int a = 0, int b = 0)
        {
            this.a = a;
            this.b = b;
        }

        public int Sum()
        {
            return a + b;
        }
    }
}
