using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metoder_Filer_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                string input1 = "";//Laver min variable global så jeg kan bruge den flere steder 
                Console.WriteLine("Tilføj fil(1)    Slet fil(2)     Vis filer(3)    Tilføj mappe(4)     Søg efter filer(5)      Søg efter type(6)       Luk programmet(7)");
                int whichone = int.Parse(Console.ReadLine());//Bruger input
                switch (whichone) //Valgmulighederne
                {
                    case 1:
                        Console.WriteLine("Skriv navnet på filen.");
                        input1 = Console.ReadLine();//Brugerinput
                        AddFile(input1);//Bruger min metode
                        break;
                    case 2:
                        Console.WriteLine("Skriv navnet på filen i den lokale folder du vil slette");
                        input1 = Console.ReadLine();
                        DeleteFile(input1);
                        break;
                    case 3:
                        Console.WriteLine(@"Viser filer og mapper fra C:\");
                        ViewFileAndFolder();
                        break;
                    case 4:
                        Console.WriteLine("Tiltøj en mappe i den lokale mappe som programmet ligger i");
                        input1 = Console.ReadLine();
                        AddFolder(input1);
                        break;
                    case 5:
                        Console.WriteLine("Søg efter et navn på en fil");
                        input1 = Console.ReadLine();
                        SearchFileName(input1);
                        break;
                    case 6:
                        Console.WriteLine("Søg efter fil type");
                        input1 = Console.ReadLine();
                        SearchFileType(input1);
                        break;
                    case 7:
                        Environment.Exit(0);//Lukker programmet
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
        //Alle mine metoder
        private static void SearchFileType(string input)
        {
            foreach (var files in Directory.GetFiles(@".\Droids", $"*.{input}"))//For hver fil der er i det valgte directory bliver der udskrevet sti'en
            {
                Console.WriteLine(files);
            }
        }

        private static void SearchFileName(string foldernameinput)
        {
            foreach (var files in Directory.GetFiles(@"C:\Users\kjedt\source\repos_git", $"{foldernameinput}", SearchOption.AllDirectories)) //For hver fil der er i det valgte directory bliver der udskrevet sti'en
            {
                Console.WriteLine(files);
            }
        }

        private static void AddFolder(string foldername)
        {
            Directory.CreateDirectory($@".\{foldername}");//tilføjer en mappe i mappen programmet ligger i med det navn som brugeren skriver 
        }

        private static void ViewFileAndFolder()
        {
            foreach (var files in Directory.GetFiles(@"C:\Users\kjedt\source\repos_git", "*",SearchOption.AllDirectories)) //viser alle filer i mappen repos_git.
            {
                Console.WriteLine(files);
            }
        }

        private static void DeleteFile(string filename)// sletter en fil med passende navn som brugeren skriver ind.
        {
            File.Delete($@".\{filename}.txt");
        }

        private static void AddFile(string filename) // tilføjer en fil med passende navn som brugeren skriver ind.
        {
            FileStream file = new FileStream($@".\{filename}.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.Close();
        }
    }
}
