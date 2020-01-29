using System;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv den danske krone du vil omregne!");
            double dkinput = double.Parse(Console.ReadLine()); //Her bliver input lavet til double

            //Her udregner jeg kurserne
            double usd = dkinput * 0.15;
            double pund = dkinput * 0.11;
            double euro = dkinput * 0.13;
            double skrone = dkinput * 1.42;

            //Her udskriver jeg valutaerne.
            Console.WriteLine("US dollars " + usd);
            Console.WriteLine("Engelske pund " + pund);
            Console.WriteLine("Euro " + euro);
            Console.WriteLine("Svenske kroner " + skrone);

        }
    }
}
