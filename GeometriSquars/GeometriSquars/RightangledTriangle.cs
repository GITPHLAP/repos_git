using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquars
{
    class RightangledTriangle : Shape
    {
        private double sideb;
        private double sidec;
        public double Sideb
        {
            set
            {
                this.sideb = value;
            }
            get
            {
                return sideb;
            }
        }
        public double Sidec
        {
            set
            {
                this.sidec = value;
            }
            get
            {
                return sidec;
            }
        }

        public RightangledTriangle()
        {

        }
        public RightangledTriangle(double sidea, double sideb, double sidec)
        {
            this.Sidea = sidea;
            this.sideb = sideb;
            this.sidec = sidec;
        }
        public override double Perimeter() // laver metoden til at regne omkreds
        {
            double result = this.Sidea + this.sideb + this.sidec;
            return result;
        }
        public override double Area() //laver metoden til at regne arealet
        {
            double result = 0.5 * this.Sidea * this.sideb;
            return result;
        }
    }
}
