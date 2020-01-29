using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LommeregnerMedHistorie
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameonwhattodo;
            double tal1 = 0;
            double tal2 = 0;
            Console.WriteLine("Vælg hvad du vil");
            nameonwhattodo=Console.ReadLine();
            Console.Write("Skriv det første tal");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv det andet tal");
            tal2 = Convert.ToInt32(Console.ReadLine());

            switch (nameonwhattodo)
            {
                case "plus":
                case "+":
                    Console.WriteLine($"Resulatat af {tal1} + {tal2}=" + (tal1 + tal2));
                    break;
                case "minus":
                case "-":
                    Console.WriteLine($"Resulatat af {tal1} - {tal2}=" + (tal1 - tal2));
                    break;
                case "gange":
                case "*":
                    Console.WriteLine($"Resulatat af {tal1} * {tal2}=" + (tal1 * tal2));
                    break;
                case "dividere":
                case "/":
                    Console.WriteLine($"Resulatat af {tal1} / {tal2}=" + (tal1 / tal2));
                    break;
            }
            Console.ReadLine();


        }
    }
}
