using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class Kolekce
    {
        //FIFO first in first out - fronta
        Queue fronta = new Queue();

        //Zasobnik LIFO last in first out
        Stack zasobnik = new Stack();
        //hashtable 
        Hashtable table = new Hashtable();

        public void NaplnFrontu()
        {
            fronta.Enqueue("Pavel");
            fronta.Enqueue("Pepa");
            fronta.Enqueue("Jano");

            string s = (string)fronta.Dequeue();

            foreach (string s1 in fronta)
            {
                Console.WriteLine(s1);
            }

        }

        public void NaplnZasobnik()
        {
            zasobnik.Push(10);
            zasobnik.Push(5);
            zasobnik.Push("Pavel");
            zasobnik.Push("Peter");

            string s = zasobnik.Pop().ToString();

            foreach (object s2 in zasobnik)
            {
                Console.WriteLine(s2);
            }
        }

        public void NaplnTabulku()
        {
            table["Pave Sanca"] = "4673483254";
            table["Jakub"] = "587645642";
            table.Remove("Jakub");
        }
    }
}
