using System;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indsætter værdierne
            Console.WriteLine("Skriv dit navn");
            string Name = Console.ReadLine();
            Console.WriteLine("Skriv din alder");
            uint Age = uint.Parse(Console.ReadLine());

            //Finder ud af hvor alderen passer til
            if (Age < 3)//hvis alderen er mindre end 3
            {
                Console.WriteLine($"{Name} du må gå med ble");
            }
            else if (Age >= 18)//hvis alderen er 18 og derover
            {
                Console.WriteLine($"{Name} du må stemme og køre bil");
            }
            else if (Age >= 15)//hvis alderen er 15 og derover, hvis den er over 18 bliver den fanget af betingelsen ovenover
            {
                Console.WriteLine($"{Name} du må drikke");
            }
            else if (Age >= 3)//hvis alderen er 3 og derover
            {
                Console.WriteLine($"{Name} du må ingenting");
            }
        }
    }
}
