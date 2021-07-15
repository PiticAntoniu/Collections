using System.Collections;

namespace Collections
{
    internal class Questie : IEnumerable, IEnumerator
    {
        string name = "Toni";
        string surname = "Pitic";
        int grade = 5;

        int current = 0;
        public object Current
        {
            get
            {
                if (current == 1) return name;
                if (current == 2) return surname;
                if (current == 3) return grade;
                return 0;
            }
        }

        public bool MoveNext()
        {
            current++;
            return current < 4;
        }

        public void Reset()
        {
            current = 0;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}