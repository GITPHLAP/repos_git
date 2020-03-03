using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquars
{
    class Parallelogram : Rectangle
    {
        private double degress;

        public double Degress
        {
            set
            {
                this.degress = value;
            }
            get
            {
                return degress;
            }
        }
        
        public Parallelogram()
        {

        }
        public Parallelogram(double sidea, double sideb, double degress)
        {
            this.Sidea = sidea;
            this.Sideb = sideb;
            this.degress = degress;
        }
        public override double Perimeter() // laver metoden til at regne omkreds
        {
            double result = (this.Sidea * 2) + (this.Sideb * 2);
            return result;
        }
        public override double Area() //laver metoden til at regne arealet
        {
            double result = this.Sidea * this.Sideb * Math.Sin(degress*3.14/180);
            return result;
        }

    }
}
