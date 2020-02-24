using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaskemaskine
{
    class WashingMachine
    {
        private bool power; //laver en tænd og sluk kontakt 

        public bool Power //gøre den public
        {
            set
            {
                power = value;
            }
            get
            {
                return power;
            }

        }


        public void turnonandoff() //metode til at slukke og tænde maskinen 
        {
            if (this.power == true)
            {
                this.power = false;
                Console.WriteLine("Maskinen er slukket");
            }
            else
            {
                this.power = true;
                Console.WriteLine("Maskinen er tændt");
            }
            
        }


        public void Filling()
        {
            if (this.power == false)//tester om maskinen er slukket 
            {
                return;
            }
            Console.WriteLine("Vaskmaskinen er i gang med at blive fyldt");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Resterende tid {i}");// laver en tæller 
            }
        }
        public void Washing()
        {
            if (this.power == false)
            {
                return;
            }
            Console.WriteLine("Vaskmaskinen er i gang med at vaske");
            for (int i = 20; i >= 0; i--)
            {
                Console.WriteLine($"Resterende tid {i}");
            }
        }
        public void EcoWashing()
        {
            if (this.power == false)
            {
                return;
            }
            Console.WriteLine("Vaskmaskinen er i gang med at vaske ECO");
            for (int i = 20; i >= 0; i--)
            {
                Console.WriteLine($"Resterende tid {i}");
            }
        }
        public void Spinning()
        {
            if (this.power == false)
            {
                return;
            }
            Console.WriteLine("Vaskmaskinen er i gang med at spin my head round and round");
            for (int i = 25; i >= 0; i--)
            {
                Console.WriteLine($"Resterende tid {i}");
            }
        }
    }
}
