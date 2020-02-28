using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Machine
    {
        private int totalofmoney;//tilføjer mit total tjente penge felt
        public Dictionary<string, Stack<Product>> stock = new Dictionary<string, Stack<Product>>();
        public int Totalofmoney
        {
            set
            {
                this.totalofmoney = value;
            }
            get
            {
                return totalofmoney;
            }
        }
       
        //Metoder
        public Machine()//konstruktør så når der bliver lavet en maskine bliver der tilføjet følgende
        {
            stock.Add("lollypop", new Stack<Product>());//den tilføjer en stak med nøglen lollypop
            stock.Add("colasoda", new Stack<Product>());
            stock.Add("cornybar", new Stack<Product>());
            Fill();//her kalder den metoden så den kan fylde vare i automaten
        }
        public void Fill()//metode til at fylde automaten op fra start af programmet.
        {
            for (int i = 0; i < 10; i++)//køre 10 gange
            {
                stock["lollypop"].Push(new Product("Cola slikkepind", 19));//tilføjer en cola slikkepind til 19.
            }
            for (int i = 0; i < 10; i++)
            {
                stock["cornybar"].Push(new Product("Cornybar med ckokolade", 35));
            }
            for (int i = 0; i < 10; i++)
            {
                stock["colasoda"].Push(new Product("Haribo Cola", 26));
            }
        }
        public void Refill()//genopfylder metode
        {
            int amountofproductLP = stock["lollypop"].Count(); //set en variable på hvor mange lollypop der er er lige nu
            int amountofproductCb = stock["cornybar"].Count();
            int amountofproductCs = stock["colasoda"].Count();
            if (amountofproductLP < 10) //hvis antalet af lollypop er unde r10 sker dette
            {
                int amountToFill = 10 - amountofproductLP; //finder ud af hvor vare der skal tilføjes
                for (int i = 0; i <= amountToFill; i++)//antalet af vare der skal tilføjes er antalet af hvor mange gange loop køre
                {
                    stock["lollypop"].Push(new Product("Cola slikkepind", 19));//tilføjer varen
                }
                    Console.WriteLine("har fyldt " + amountToFill + " Cola slikkepind");//udskriver hvor mange af varen der er blevet tilføjet
            }
            if (amountofproductCb < 10)
            {
                int amountToFill = 10 - amountofproductLP;
                for (int i = 0; i <= amountToFill; i++)
                {
                    stock["cornybar"].Push(new Product("Cornybar med ckokolade", 35));
                }
                Console.WriteLine("har fyldt " + amountToFill + " Cornybar med ckokolade");

            }
            if (amountofproductCs < 10)
            {
                int amountToFill = 10 - amountofproductLP;
                for (int i = 0; i <= amountToFill; i++)
                {
                    stock["colasoda"].Push(new Product("Haribo Cola", 26));
                }
                Console.WriteLine("har fyldt " + amountToFill + " Haribo Cola");

            }
        }
        public void Showall()//hviser lager beholdningen
        {
            Console.WriteLine(stock["lollypop"].Peek().Name + " Antal: " + stock["lollypop"].Count());//udskriver navnet af productet og antalet
            Console.WriteLine(stock["cornybar"].Peek().Name + " Antal: " + stock["cornybar"].Count());//udskriver navnet af productet og antalet
            Console.WriteLine(stock["colasoda"].Peek().Name + " Antal: " + stock["colasoda"].Count());//udskriver navnet af productet og antalet
        }
        public Product Buyone(string whichproduct)//return som et product og skal have input som en string 
        {
            totalofmoney += stock[whichproduct].Peek().Price; //jeg tilføjer prisen på det product der er købt til antal tjente penge
            return stock[whichproduct].Pop();//jeg returner produktet og smider det ud af min stak
        }

        public void Seeproduct(string whichproduct)//Ser hvilket product der er valgt
        {
            Console.WriteLine(stock[whichproduct].Peek().Name + ", " + stock[whichproduct].Peek().Price + "kr.");//udskriver navn og pris
        }
        public int SetPriceToVariable(string whichproduct)//Metode til at kalde på prisen af det valgte product
        {
            return stock[whichproduct].Peek().Price;//returner prisen
        }

        public void CollecttheMoney()//indsamler pengene 
        {
            Console.WriteLine("Du har indsamlede: " + totalofmoney + " kr.");//udskriver hvor mange penge der er blevet taget
            totalofmoney = 0;//sætter tælleren af penge til nul
        }
        public void ChangePrice(string whichproduct, int newprice)//ændre prisen på 
        {
            foreach (var item in stock[whichproduct])//ændre prisen på hvert product i stakken
            {
                item.Price = newprice;//sætter prisen til den nye pris
                Console.WriteLine("Prisen på " + item.Name + " er blevet ændret til " + item.Price + " kr.");//udskriver den nye pris
            }
        }
    }
}
