using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDB databaza = new StudentDB();
            databaza.LoadStudenty();
            Student[] setrideniStudenti;
            bool trideno = databaza.Setrid(databaza.poleStudenti, out setrideniStudenti);
            foreach (Student s in setrideniStudenti)
            {
                Console.WriteLine(s.Jmeno + " " + s.Primeni + " " + s.Vek);
            }
            Console.WriteLine();
            foreach (Student s in databaza.poleStudenti)
            {
                Console.WriteLine(s.Jmeno + " " + s.Primeni + " " + s.Vek);
            }

            Console.ReadLine();
        }
    }
}
