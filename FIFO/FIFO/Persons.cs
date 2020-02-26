using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Persons
    {
        //opretter felterne prvate
        private string name;
        private int age;
        private string gender;


        static Queue<Persons> guests = new Queue<Persons>(); //Opretter min kø, jeg gør den statisk fordi at det skal være den samme kø hele tiden




        #region get/set
        //opretter felterne public
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return age;
            }
        }
        public string Gender
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return gender;
            }
        }
        #endregion get/set

        // laver en default konstruktør 
        public Persons()
        {
            
        }

        //laver en konstruktør som tilføjer inputtet til listen
        public Persons(string Iname, int Iage, string Igender)
        {
            this.name = Iname;
            this.age = Iage;
            this.gender = Igender;
            guests.Enqueue(this);
        }

        //Metode til at vise alle
        public void Showall()
        {
            foreach (var item in guests)//køre hvergang der er noget i køen
            {
                Console.WriteLine(item.name);//udskriver navnet
            }
        }

        public void removeperson()
        {
            guests.Dequeue();//fjerne den foreste person i køen
        }
        public void number()
        {
            Console.WriteLine("Der er " + guests.Count() + " gæster");//finder antalet af gæster
        }

        public void MinAndMax()//finder minimum og maximum
        {
            Console.WriteLine("Den ældste gæst til festen er "+guests.Max(guest => guest.age)+" år gammel");
            Console.WriteLine("Den yngste gæst til festen er "+guests.Min(guest => guest.age)+" år gammel");
        }

        public void Findsomeone(string inputname)//leder efter det navn som er blevet skrevet
        {
            foreach (var item in guests)
            {
                if (inputname == item.name)
                {
                    Console.WriteLine("Navn: "+item.name);
                    Console.WriteLine("Alder: "+item.age);
                    Console.WriteLine("Køn: "+item.gender);
                }
            }
        }
    }
}
