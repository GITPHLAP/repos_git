using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            Square test = new Square(2); //Laver en kvadrat med længden 2

            Console.WriteLine("TEST");
            Console.WriteLine(test.Perimeter()); //udskriver omkredsen
            Console.WriteLine(test.Area()); //udskriver arealet

            Square test2 = new Square(); //Laver en kvadrat uden parameter
            test2.Side = 3; //giver kvadratet parameterne nu 

            test.Side = 5; //ændre første kvadrats værdier

            Console.WriteLine("After TEST");
            Console.WriteLine(test.Perimeter());
            Console.WriteLine(test.Area());
            Console.WriteLine("TEST2");
            Console.WriteLine(test2.Perimeter());
            Console.WriteLine(test2.Area());

            Console.ReadLine();
        }
    }
}
