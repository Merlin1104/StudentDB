using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class StudentDB
    {
        const int delkaPole = 10;
        string[] jmeno = new string [] {"Peter", "Michal", "Tomas", "Jano", "Istvan" };
        string[] prijmeni = new string[] {"Cierny", "Zeleny", "Novak", "Biely", "Hrnciar" };
        public Student[] poleStudenti= new Student[delkaPole]; //aby to nebolo pole stringov, ale pole studentov 
        //tuto zacina Array list
        public ArrayList seznamStudentu = new ArrayList();
        

        Random nahodneCislo = new Random();

        public void LoadStudenty()
        {
            for (int i = 0; i < poleStudenti.Length; i++)
            {
                Student student;
                student.Jmeno = jmeno[nahodneCislo.Next(jmeno.Length)];
                student.Primeni = prijmeni[nahodneCislo.Next(prijmeni.Length)];
                student.Vek = nahodneCislo.Next(15, 80);

                poleStudenti[i] = student;
                seznamStudentu.Add(student);
                
            }
        }

        public bool Setrid(Student[] studenti, out Student[] setridenePole)
        {
            bool byloTrideno = false; // bolo triedene ?
            setridenePole = (Student[])studenti.Clone(); //(Student []) pretypovavam
            for (int i = 0; i < setridenePole.Length; i++)
            {
                for (int j = 0; j < setridenePole.Length - 1; j++)
                {
                    if (setridenePole[j].Vek > setridenePole[j+1].Vek)
                    {
                        Student tempStudent = setridenePole[j + 1];
                        setridenePole[j + 1] = setridenePole[j];
                        setridenePole[j] = tempStudent;
                        byloTrideno = true;
                    }
                }
            }
            return byloTrideno;
        }


    }
}
