using System;

namespace SmallAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg hvad du vil, der er følgende valgmuligheder:");
            Console.WriteLine("Skriv 'Fib' hvis du vil vælge Fibonace opgaven");
            string input;
            input = Console.ReadLine();

            if (input == "Fib")
            {
                Fibo.Fibonumber(input);
            }
            else if (input == "Bin")
            {
                int inputnumber = 0;
                Console.WriteLine("Decimal til Binær");
                inputnumber = int.Parse(Console.ReadLine());


            }
      
            else
            {
                Console.WriteLine("Det du har indtastet gav ikke noget resultat:(");
            }





            
            Console.ReadLine();
        }
    }
}
