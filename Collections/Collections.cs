using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // C R U D

    class Collections
    {
        

        SortedList<string,Student> L = new SortedList<string,Student>();


        public void f()
        {
            AddMockData();

            foreach (var student in L)
            {
                Console.WriteLine(student.Value.Nume + ": " + student.Value.Nota);
            }

        }

        private void AddMockData()
        {
            L.Add("Toni",
                new Student
                {
                    Nume = "Toni",
                    Nota = 5

                }
                );
            L.Add("Ana",
                        new Student
                        {
                            Nume = "Ana",
                            Nota = 9

                        }
                        );
            L.Add("Dorel",
                        new Student
                        {
                            Nume = "Dorel",
                            Nota = 2

                        }
                        );
        }
    }
}
