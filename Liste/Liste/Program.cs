using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> listeB = new List<int>(); //tilføjer listeB
            List<int> listeBRevers = new List<int>();//tiføjer den nye liste som er omvendt
            //Det her for-loop tilføjer elementerne
            for (int i = 1; i <= 20; i++)
            {
                if ((i % 2) == 0)
                {
                    listeB.Add(i);
                    
                }
            }
            //her fjerner jeg alle de tal som går op  3
            for (int j = 0; j <= listeB.Count -1; j++)
            {
                if ((listeB[j] % 3) == 0)
                {
                    listeB.Remove(listeB[j]);
                }

            }
            Console.WriteLine($"Der er {listeB.Count} elementer i listen"); //udskriver jeg antalet af elementer i min liste
            //Ændre plads 3's værdi til 17
            for (int k = 0; k <= listeB.Count -1; k++)
            {
                if (k == 2)
                {
                    listeB[k] = 17;
                }
            }
            listeB.Reverse();//reverser listen
            //Tilføjer ListeB til den nye liste bare i omvendt rækkefølge
            for (int i = 0; i <= listeB.Count -1; i++)
            {
                listeBRevers.Add(listeB[i]);
            }
        }
    }
}
