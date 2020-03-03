using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSquars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Shape(2));
            shapes.Add(new RightangledTriangle(3, 6, 9));
            shapes.Add(new Rectangle(3, 6));
            shapes.Add(new Parallelogram(3, 5, 20));
            shapes.Add(new Trapeze(10, 9, 8, 9));

            foreach (var item in shapes)
            {
                if (item.GetType().ToString() == "GeometriSquars.Shape")
                {
                    Console.WriteLine("GeometriSquars.Square");
                }
                else
                {
                    Console.WriteLine(item.GetType());
                }
                Console.WriteLine("Omkredsen: " + item.Perimeter());
                Console.WriteLine("Arealet: " + item.Area());
                Console.WriteLine("---------------------------------------------");

            }
            Console.ReadLine();
        }
    }
}
