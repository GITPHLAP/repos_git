using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquars
{
    class Rectangle : Shape
    {
        private double sideb; // sætter første felt
        public double Sideb //laver et public felt
        {
            set
            {
                sideb = value;
            }
            get
            {
                return sideb;
            }

        }
        public Rectangle()
        {
        }
        public Rectangle(double sidea, double sideb)
        {
            this.Sidea = sidea;
            this.sideb = sideb;
        }
        public override double Perimeter() // laver metoden til at regne omkreds
        {
            double result = (this.Sidea * 2) + (this.sideb * 2);
            return result;
        }
        public override double Area() //laver metoden til at regne arealet
        {
            double result = this.Sidea * this.sideb;
            return result;
        }
    }
}
