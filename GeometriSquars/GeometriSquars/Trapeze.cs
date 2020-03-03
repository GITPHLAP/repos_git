using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquars
{
    class Trapeze : Rectangle
    {
        private double sidec;
        private double sided;

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
        public double Sided
        {
            set
            {
                this.sided = value;
            }
            get
            {
                return sided;
            }
        }



        public Trapeze(double sidea, double sideb, double sidec, double sided)
        {
            this.Sidea = sidea;
            this.Sideb = sideb;
            this.sidec = sidec;
            this.sided = sided;
        }
        private double CalculateSideS()
        {
            return (this.Sidea + this.Sideb - this.sidec + this.sided) / 2;
        }
        private double CalculateHeight()
        {
            double sides = CalculateSideS();
            return (2 / (this.Sidea - this.sidec)) * Math.Sqrt(sides * (sides - this.Sidea + sidec) * (sides - this.Sideb) * (sides - this.sided));
        }

        public override double Perimeter() // laver metoden til at regne omkreds
        {
            double result = this.Sidea + this.Sideb + this.sidec + this.sided;
            return result;
        }
        public override double Area() //laver metoden til at regne arealet
        {
            double result = 0.5 * (this.Sidea +this.sidec) * CalculateHeight();
            return result;
        }

    }
}
