using System;

namespace GætEtTal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gæt tallet jeg tænker på tallet er mellem 1 og 20!");
            //laver en randomizer til tallet 
            Random TheNumber = new Random();
            //Sætter hvilken værdi den skal være
            int IntTheNumber = TheNumber.Next(1, 21);
            int tries = 0; //forsøget starter på 0
            bool continueloop = true; //fortælle om loop skal fortsætte
            while (continueloop)
            {
                ++tries;//ligger 1 til forsøg
                int guessnumber = int.Parse(Console.ReadLine());//indsamler input
                if (guessnumber == IntTheNumber)
                {
                    continueloop = false;//bliver brugt til at stoppe loop
                }
                else if (guessnumber > IntTheNumber)
                {
                    Console.WriteLine("Det er lidt for højt, prøv igen:)");//Fortæler brugeren at tallet var højt
                }
                else
                {
                    Console.WriteLine("Det er lidt for lavt, prøv igen:)");//Fortæler brugeren at tallet var lavt
                }

            }
            //fortæller brugeren at tallet blev gættet
            if (tries > 6)
            {
                Console.WriteLine("Du er mega dårlig");
            }
            else
            {
                Console.WriteLine("Du jo den bedste!!");
            }
            Console.WriteLine($"Du gættede tallet {IntTheNumber} du brugte {tries} forsøg");

        }
    }
}
