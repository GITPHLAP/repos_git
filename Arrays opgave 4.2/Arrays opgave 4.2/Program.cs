using System;
using System.Collections;

namespace Arrays_opgave_4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool findelemen = false;
            int findelemcounter = 0;
            string[] dataarr = new string[1000];
            int index = 0;
            while (true)
            {


                Console.WriteLine("vælg en af nedenstående");
                Console.WriteLine("Tast 1 for at tilføje nyt data");
                Console.WriteLine("Tast 2 for at se alle indtstede data");
                Console.WriteLine("Tast 3 for at finde et element");
                Console.WriteLine("Tast 4 for at se et resume");
                Console.WriteLine("Tast 5 afslut programmet");
                int whichone = int.Parse(Console.ReadLine());
                
                if (whichone == 1)
                {

                    Console.WriteLine("Skriv den data du vil indsætte");
                    string inputdata = Console.ReadLine();
                    dataarr[index] += inputdata;
                    index++;
                }
                else if (whichone == 2)
                {
                    for (int i = 0; i < index; i++)
                    {
                        Console.WriteLine(dataarr[i]);
                    }
                }
                else if (whichone == 3)
                {
                    Console.WriteLine("Skriv hvad du vil søge efter");
                    string finddata = Console.ReadLine();
                    for (int i = 0; i <= dataarr.Length - 1; i++)
                    {
                        if (dataarr[i] == finddata)
                        {
                            findelemen = true;
                            findelemcounter = i;
                        }
                    }
                    if (findelemen == true)
                    {
                        Console.WriteLine("Jubii vi fandt det: " + dataarr[findelemcounter]);
                    }
                    else
                    {
                        Console.WriteLine("Desværre var der ikke det du søgte efter");
                    }

                }
                else if (whichone == 4)
                {
                    Console.WriteLine("Antal spil: " + index);
                    //jeg har ikke skrevet sum gennemsnit maximum og minimum efter aftale med Mikkel
                }
                else if (whichone == 5)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
