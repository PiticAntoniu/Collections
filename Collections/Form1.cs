using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //GenericClass<int> t = new GenericClass<int>(12, 13);
            //Console.WriteLine(t.Sum());

            //GenericClass<float> q = new GenericClass<float>((float)1.25, (float)2.40);
            //Console.WriteLine(q.Sum());

            //LINQTest t = new LINQTest();
            //t.f(new int[] { 2, 4, 6, 8 });
            //t.f("Toni");
            //t.f(new Questii());

            //Questie q = new Questie();

            //foreach (var t in q)
            //{
            //    Console.WriteLine(t);
            //}

            //q.Reset();

            //foreach (var t in q)
            //{
            //    Console.WriteLine(t);
            //}

            cars c = new cars();
            foreach (car t in c)
            {
                Console.WriteLine(t.Make);
            }

            foreach (car t in c)
            {
                Console.WriteLine(t.Make);
            }


        }

        private void colletionsTestButton_Click(object sender, EventArgs e)
        {
            Collections t = new Collections();
            t.f();
        }

        private void orderByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int x in a.OrderByDescending(x => x)) // f
            {
                Console.WriteLine(x);
            }
        }

        private void orderByOnStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[]
            {
                new Student{Nume="Ana", Nota = 5},
                new Student{Nume="Ana", Nota = 9},
                new Student{Nume="Dorel", Nota = 2},
                new Student{Nume="Dorel", Nota = 7}
            };

            foreach (Student student in students.OrderBy(x => x.Nume))
            {
                Console.WriteLine(student.Nume + " " + student.Nota);
            }

            foreach (Student student in students.OrderByDescending(x => x.Nota))
            {
                Console.WriteLine(student.Nume + " " + student.Nota);
            }

            var sortedStudents = students.OrderBy(x => x.Nota).OrderByDescending(x => x.Nume);
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.Nume + " " + student.Nota);
            }

        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int elem in a.Where( x => x % 2 == 0))
            {
                Console.WriteLine(elem);
            }

            foreach (int elem in a.Where( x => Prim(x)))
            {
                Console.WriteLine(elem);
            }


        }

        private bool Prim(int n)
        {
            for(int d = 2; d <= n / 2; d++)
            {
                if (n % d == 0) return false;
            }
            return true;
        }

        private void filtersOnStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[]
{
                new Student{Nume="Toni", Nota = 5, Grupa = "Prof"},
                new Student{Nume="Ana", Nota = 9, Grupa = "221"},
                new Student{Nume="Dorel", Nota = 2, Grupa = "221"},
                new Student{Nume="Popescu", Nota = 7, Grupa = "221"}
            };

            foreach (Student st in students.Where(x => x.Nota >= 5))
            {
                Console.WriteLine(st.Nume + " " + st.Nota + "    grupa:" + st.Grupa);
            }

            foreach (Student st in students.Where(x => x.Nota >= 5 && x.Grupa != "Prof"))
            {
                Console.WriteLine(st.Nume + " " + st.Nota + "    grupa:" + st.Grupa);
            }


        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region generate mock data
            List<Student> students = new List<Student>();
            students.Add(new Student { Nume = "Toni", Nota = 5, Grupa = "Prof" });
            students.Add(new Student { Nume = "Toma", Nota = 4, Grupa = "221" });
            students.Add(new Student { Nume = "Cretu", Nota = 5, Grupa = "222" });
            students.Add(new Student { Nume = "Cretulescu", Nota = 3, Grupa = "221" });
            students.Add(new Student { Nume = "Bondar", Nota = 7, Grupa = "411" });
            students.Add(new Student { Nume = "Bolivar", Nota = 8, Grupa = "412" });
            students.Add(new Student { Nume = "Tamas", Nota = 2, Grupa = "411" });
            students.Add(new Student { Nume = "Joe", Nota = 3, Grupa = "311" });
            students.Add(new Student { Nume = "Pavel", Nota = 9, Grupa = "Prof" });
            #endregion

            foreach (var t in students.OrderBy(x=>x.Nota))
            {
                Console.WriteLine(t.Nume + "-" + t.Nota);
            }
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region generate mock data
            List<Student> students = new List<Student>();
            students.Add(new Student { Nume = "Toni", Nota = 5, Grupa = "Prof" });
            students.Add(new Student { Nume = "Toma", Nota = 4, Grupa = "221" });
            students.Add(new Student { Nume = "Cretu", Nota = 5, Grupa = "222" });
            students.Add(new Student { Nume = "Cretulescu", Nota = 3, Grupa = "221" });
            students.Add(new Student { Nume = "Bondar", Nota = 7, Grupa = "411" });
            students.Add(new Student { Nume = "Bolivar", Nota = 8, Grupa = "412" });
            students.Add(new Student { Nume = "Tamas", Nota = 2, Grupa = "411" });
            students.Add(new Student { Nume = "Joe", Nota = 3, Grupa = "311" });
            students.Add(new Student { Nume = "Pavel", Nota = 9, Grupa = "Prof" });
            #endregion

            foreach (var t in students.OrderBy(x => x.Nota).Select(x => x.Nume + " " + x.Grupa + "    Nota:" + x.Nota))
            {
                Console.WriteLine(t);
            }
        }


        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region generate mock data
            List<Student> students = new List<Student>();
            students.Add(new Student { Nume = "Toni", Nota = 5, Grupa = "Prof" });
            students.Add(new Student { Nume = "Toma", Nota = 4, Grupa = "221" });
            students.Add(new Student { Nume = "Cretu", Nota = 5, Grupa = "222" });
            students.Add(new Student { Nume = "Cretulescu", Nota = 3, Grupa = "221" });
            students.Add(new Student { Nume = "Bondar", Nota = 7, Grupa = "411" });
            students.Add(new Student { Nume = "Bolivar", Nota = 8, Grupa = "412" });
            students.Add(new Student { Nume = "Tamas", Nota = 2, Grupa = "411" });
            students.Add(new Student { Nume = "Joe", Nota = 3, Grupa = "311" });
            students.Add(new Student { Nume = "Pavel", Nota = 9, Grupa = "Prof" });
            #endregion

            var studentiRestantieriDinAnul2 = students.Where(x => x.Nota < 5 && x.Grupa.StartsWith("2"));

            foreach (var t in studentiRestantieriDinAnul2.Select(x => x.Nume + " " + x.Grupa + "    Nota:" + x.Nota))
            {
                Console.WriteLine(t);
            }
        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(a.Sum());
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region generate mock data
            List<Student> students = new List<Student>();
            students.Add(new Student { Nume = "Toni", Nota = 10, Grupa = "Prof" });
            students.Add(new Student { Nume = "Toma", Nota = 4, Grupa = "221" });
            students.Add(new Student { Nume = "Cretu", Nota = 5, Grupa = "222" });
            students.Add(new Student { Nume = "Cretulescu", Nota = 3, Grupa = "221" });
            students.Add(new Student { Nume = "Bondar", Nota = 7, Grupa = "411" });
            students.Add(new Student { Nume = "Bolivar", Nota = 8, Grupa = "412" });
            students.Add(new Student { Nume = "Tamas", Nota = 2, Grupa = "411" });
            students.Add(new Student { Nume = "Joe", Nota = 3, Grupa = "311" });
            students.Add(new Student { Nume = "Pavel", Nota = 9, Grupa = "Prof" });
            #endregion

            Console.WriteLine(students.Average(x => x.Nota));
        }

        private void mediaCelorDeAnul2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region generate mock data
            List<Student> students = new List<Student>();
            students.Add(new Student { Nume = "Toni", Nota = 5, Grupa = "Prof" });
            students.Add(new Student { Nume = "Toma", Nota = 4, Grupa = "221" });
            students.Add(new Student { Nume = "Cretu", Nota = 5, Grupa = "222" });
            students.Add(new Student { Nume = "Cretulescu", Nota = 3, Grupa = "221" });
            students.Add(new Student { Nume = "Bondar", Nota = 7, Grupa = "411" });
            students.Add(new Student { Nume = "Bolivar", Nota = 8, Grupa = "412" });
            students.Add(new Student { Nume = "Tamas", Nota = 2, Grupa = "411" });
            students.Add(new Student { Nume = "Joe", Nota = 3, Grupa = "311" });
            students.Add(new Student { Nume = "Pavel", Nota = 9, Grupa = "Prof" });
            #endregion

            Console.WriteLine(  students.Where(x => x.Grupa.StartsWith("2")).Average(x=>x.Nota) );
        }
    }
}
