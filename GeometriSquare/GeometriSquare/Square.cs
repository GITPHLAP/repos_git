using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquare
{
    public class Square
    {
        private double side; // sætter første felt
        public double Side //laver et public felt
        {
            set
            {
                side = value;
            }
            get
            {
                return side;
            }

        }
        public Square()// laver en tom konstruktør
        {

        }
        public Square(double a) //Laver en konstruktør med parameter
        {
            this.side = a;
        }
        public double Perimeter() // laver metoden til at regne omkreds
        {
            double result = this.side * 4;
            return result;
        }
        public double Area() //laver metoden til at regne arealet
        {
            double result = this.side * this.side;
            return result;
        }
    }
}
