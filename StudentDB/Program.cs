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
            Console.WriteLine("LINE");
            foreach (Student s in databaza.seznamStudentu)
            {
                Console.WriteLine(s.Jmeno + " " + s.Primeni + " " + s.Vek);
            }

            //inlinovy if
            bool bylo;
            //if (trideno) bylo = true;
            bylo = (trideno) ? true : false;

            Console.WriteLine();

            Kolekce k = new Kolekce();
            k.NaplnFrontu();
            Console.WriteLine();
            k.NaplnZasobnik();
            Console.WriteLine();
            k.NaplnTabulku();

           

            Console.ReadLine();
        }
    }
}
