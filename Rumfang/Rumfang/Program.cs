using System;

namespace Rumfang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv bredden!");
            double width = double.Parse(Console.ReadLine()); //Her bliver bredden konverteret til double
            Console.WriteLine("Skriv længden!");
            double length = double.Parse(Console.ReadLine()); //Her bliver bredden konverteret til double
            Console.WriteLine("Skriv højden!");
            double high = double.Parse(Console.ReadLine()); //Her bliver bredden konverteret til double

            //her bliver resultatet udskrevet.
            Console.WriteLine($"Rumfanget er {width*length*high}");


        }
    }
}
