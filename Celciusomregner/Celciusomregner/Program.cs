using System;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        { 

         Console.WriteLine("Skriv graderne i Celcius");
         double c = double.Parse(Console.ReadLine());

         double reamur = c*0.8; //Her udregner den Reamur;
         double fehren = c*1.8+32; //Her udregner den Fahrenheit
         //Her udskriver jeg alle værdierne
         Console.WriteLine("Celcius " + c);
         Console.WriteLine("Reamur " + reamur);
         Console.WriteLine("Fahrenheit " + fehren);
        }

    }
}
