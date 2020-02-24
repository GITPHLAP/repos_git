using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquare
{
    class Person
    {
        private string name;
        private int age;
        public string Name
            {
            set
            { name = value;
            }
            get 
            {
                return name;
            }
        }



        public Person()
        { 
            
        
        }

        public Person(String n)
        {
            this.name = n;
        }





        public void count()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }        
        }


    }
}
