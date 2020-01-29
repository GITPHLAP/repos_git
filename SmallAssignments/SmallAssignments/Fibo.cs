using System;
using System.Collections.Generic;
using System.Text;

namespace SmallAssignments
{
    class Fibo
    {
        public static void Fibonumber(string input)
        {
            //Fibonance Assignment.
            //Vælg hvor mange fibonance tal der skal udskrives.

            int number;

            double n1 = 0, n2 = 1, n3;

            Console.Write("Hvor mange tal skal der udskrives? \n");

            number = int.Parse(Console.ReadLine());

            Console.Write($"{n1}  {n2}  ");

            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + "  ");

                n1 = n2;
                n2 = n3;
            }

        }
            

    }
}
