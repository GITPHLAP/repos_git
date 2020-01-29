using System;

namespace arrays_opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boynames = { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias" };

            Console.WriteLine("vælg en af følgende");
            Console.WriteLine("Tast 1 for at se listen i navne top 20 for født drengebørn i 2011");
            Console.WriteLine("Tast 2 for at sortere dem alfapetisk");
            int whichone = int.Parse(Console.ReadLine());
            if (whichone == 1)
            {
                for (int i = 0; i <= boynames.Length -1; i++)
                {
                    Console.WriteLine(boynames[i]);
                }
            }
            else if (whichone == 2)
            {
                Array.Sort(boynames);
                for (int j = 0; j <= boynames.Length -1; j++)
                {
                    Console.WriteLine(boynames[j]);
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input");//fejl besked
            }
            
        }
    }
}
