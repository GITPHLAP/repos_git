using System;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indsætter værdierne
            Console.WriteLine("Skriv værdi A");
            double inputA = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv værdi B");
            double inputB = double.Parse(Console.ReadLine());

            double calculateC = (inputA * inputA) + (inputB * inputB); //udregner C 

            //Finder ud af hvilket tal der er det størst og udskriver værdierne
            if ((inputA * inputA) > (inputB * inputB))
            {
                Console.WriteLine("Det støreste tal er A som har værdi: " + inputA);
            }
            else if ((inputA * inputA) < (inputB * inputB))
            {
                Console.WriteLine("Det støreste tal er B som har værdi: " + inputB);
            }
            else
            {
                Console.WriteLine("Talet er lige");
            }
            //udskriver C værdi
            Console.WriteLine("C: " + Math.Sqrt(calculateC));

        }
    }
}
