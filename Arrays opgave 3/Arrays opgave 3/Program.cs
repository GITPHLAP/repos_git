using System;
using System.Collections;
namespace Arrays_opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList boynamesList = new ArrayList();
            ArrayList girlnamesList = new ArrayList();//arraylist til piger
            string[] boynames = { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias" };
            for (int i = 0; i <= boynames.Length -1; i++)
            {
                boynamesList.Add(boynames[i]);

            }
            Console.WriteLine("vælg en af følgende");
            Console.WriteLine("Tast 1 for at se listen i navne top 20 for født drengebørn i 2011");
            Console.WriteLine("Tast 2 for at sortere dem alfapetisk");
            Console.WriteLine("Tast 3 for at fjerne et navn");
            int whichone = int.Parse(Console.ReadLine());
            if (whichone == 1)
            {
                for (int i = 0; i <= boynames.Length - 1; i++)
                {
                    Console.WriteLine(boynames[i]);
                }
            }
            else if (whichone == 2)
            {
                Array.Sort(boynames);
                for (int j = 0; j <= boynames.Length - 1; j++)
                {
                    Console.WriteLine(boynames[j]);
                }
            }
            else if (whichone == 3)//valg nummer 3
            {
                Console.WriteLine("Vælg om det er et drenge eller pige navn p for pige d for dreng");//vælg køn
                string whichgender = Console.ReadLine();
                if (whichgender == "p")//pige
                {
                    Console.WriteLine("Skriv navnet du vil fjerne");
                    string removegirlname = Console.ReadLine();//bruger input
                    if (girlnamesList.Contains(removegirlname))//hvis der er en bruger i listen der matcher input
                    {
                        girlnamesList.Remove(removegirlname);//fjerne brugeren
                    }
                }
                else if (whichgender == "d")//dreng
                {
                    Console.WriteLine("Skriv navnet du vil fjerne");
                    string removeboyname = Console.ReadLine();//bruger input
                    if (boynamesList.Contains(removeboyname))//hvis der er en bruger i listen der matcher input
                    {
                        boynamesList.Remove(removeboyname);//fjerne brugeren
                    }
                }
                else
                {
                    Console.WriteLine("Forkert input");
                }
                
            }
            else if (whichone == 4)
            {
                Console.WriteLine("Vælg om det er et drenge eller pige navn p for pige d for dreng");//vælg køn
                string whichgender = Console.ReadLine();
                if (whichgender == "p")
                {
                    //fjerner pige navnet der er blevet skrevet
                    Console.WriteLine("Skriv navnet du vil tilføje");
                    string addgirlname = Console.ReadLine();
                    girlnamesList.Add(addgirlname);
                }
                else if (whichgender == "d")
                {
                    //tilføjer drenge navnet der er blevet skrevet 
                    Console.WriteLine("Skriv navnet du vil tilføje"); 
                    string addboyname = Console.ReadLine();
                    boynamesList.Add(addboyname);
                }
                else
                {
                    Console.WriteLine("Forkert input");//fejl besked
                }
                
            }
            else
            {
                Console.WriteLine("Ugyldigt input");//fejl besked
            }

        }
    }
}