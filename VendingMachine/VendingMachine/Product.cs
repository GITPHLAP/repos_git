using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Product
    {
        private string name;
        private int price;

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
        public int Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return price;
            }
        }
        public Product(string nameinput, int priceinput)
        {
            this.name = nameinput;
            this.price = priceinput;
        }

    }
}
