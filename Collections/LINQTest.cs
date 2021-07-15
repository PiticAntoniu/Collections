using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LINQTest
    {

        public void f(IEnumerable input)
        {
            foreach (var c in input)
            {
                Console.WriteLine(c);
            }
        }

    }
}
