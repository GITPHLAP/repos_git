using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquars

{
    public class Shape
    {
        private double sidea; // sætter første felt
        public double Sidea //laver et public felt
        {
            set
            {
                sidea = value;
            }
            get
            {
                return sidea;
            }

        }
        public Shape()// laver en tom konstruktør
        {

        }
        public Shape(double a) //Laver en konstruktør med parameter
        {
            this.sidea = a;
        }
        public virtual double Perimeter() // laver metoden til at regne omkreds
        {
            double result = this.sidea * 4;
            return result;
        }
        public virtual double Area() //laver metoden til at regne arealet
        {
            double result = this.sidea * this.sidea;
            return result;
        }
    }
}