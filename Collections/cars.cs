using System;
using System.Collections;
namespace Collections
{
    public class cars : IEnumerator, IEnumerable
    {
        private car[] carlist;
        int position = -1;
        //Create internal array in constructor.
        public cars()
        {
            carlist = new car[6]
            {
               new car("Ford",1992),
               new car("Fiat",1988),
               new car("Buick",1932),
               new car("Ford",1932),
               new car("Dodge",1999),
               new car("Honda",1977)
            };
        }
        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
            //return carlist.GetEnumerator();
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < carlist.Length);
        }
        //IEnumerable
        public void Reset()
        {
            position = 0;
        }
        //IEnumerable
        public object Current
        {
            get { return carlist[position]; }
        }
    }
}