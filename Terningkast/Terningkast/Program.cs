using System;

namespace Terningkast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Vælg en af følgende lommeregner");
                Console.WriteLine("Tast 1 for ColorDize");
                Console.WriteLine("Tast 2 for DeluxDize");
                Console.WriteLine("Tast 3 for find ud af hvad vi skal lave");
                int pickADize;
                bool success = int.TryParse(Console.ReadLine(), out pickADize);
                if (success)
                {
                    switch (pickADize)
                    {
                        case 1:
                            ColorDize.Colorthrow();
                            break;
                        case 2:
                            DiceDelux.Deluxthrow();
                            break;
                        case 3:
                            string[] muligeder = { "Knep", "Drik", "Se Netflix", "tag på MacD" };
                            Random ranindex = new Random();
                            int rndmuligheder = ranindex.Next(0, 4);
                            Console.WriteLine($"Vi skal {muligeder[rndmuligheder]}");
                            break;
                        default:
                            Console.WriteLine("Dit input var ikke et valg? prøv igen!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Hov du, det der er jo ikke engang et tal! Tryk enter og prøv igen!");
                }

                Console.ReadLine();
                Console.Clear();
                Console.ResetColor();

                
                
                
                
            }
            
        }
    }
}
