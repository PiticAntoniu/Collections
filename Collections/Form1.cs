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

            foreach (int x in a.OrderByDescending(f))
            {
                Console.WriteLine(x);
            }
        }

        private object f(int arg)
        {
            return arg;
        }

        private void orderByOnStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[]
            {
                new Student{Nume="Toni", Nota = 5},
                new Student{Nume="Ana", Nota = 9},
                new Student{Nume="Dorel", Nota = 2},
                new Student{Nume="Popescu", Nota = 7}
            };

            foreach (Student student in students.OrderBy( g ))
            {
                Console.WriteLine(student.Nume + " " + student.Nota);
            }
        }

        private object g(Student arg)
        {
            return arg.Nume;
        }
    }
}
