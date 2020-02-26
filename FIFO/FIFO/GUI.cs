using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class GUI
    {
        public void menu()
        {
            Persons logic = new Persons();//opretter en person jeg kan bruge til at kalde min metoder


            Console.WriteLine("1. add");
            Console.WriteLine("2. fjern den første person der kom til festen");
            Console.WriteLine("3. se antal");
            Console.WriteLine("4. se ældste og yngste");
            Console.WriteLine("5. find en person");
            Console.WriteLine("6. se alle");
            Console.WriteLine("7. luk programmet");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("skriv navn");
                    string nameinput = Console.ReadLine();
                    Console.WriteLine("Skriv alder");
                    int ageinput = Int32.Parse(Console.ReadLine());//konvetere mit input til INT
                    Console.WriteLine("Skriv køn");
                    string genderinput = Console.ReadLine();
                    Persons person = new Persons(nameinput, ageinput, genderinput);//kalder en konstruktør som tilføjer personen når jeg kalder den
                    break;
                case "2":
                    logic.removeperson();//kalder mine metoder fra person
                    break;
                case "3":
                    logic.number();
                    break;
                case "4":
                    logic.MinAndMax();
                    break;
                case "5":
                    Console.WriteLine("Skriv navnet på den person du vil finde");
                    Console.WriteLine("OBS: Du skal søge på hele navnet");
                    string namefindinput = Console.ReadLine();
                    logic.Findsomeone(namefindinput);
                    break;
                case "6":
                    logic.Showall();
                    break;
                case "7":
                    Environment.Exit(1);//lukker programmet
                    break;
                default:
                    break;
            }

        }
    }
}
