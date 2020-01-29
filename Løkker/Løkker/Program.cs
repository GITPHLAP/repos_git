using System;

namespace Løkker
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave A + B
            for (int i = 0; i < 100; i++)
            {
                if (i > 50)
                {
                    Console.WriteLine(i);
                }

            }

            //OPGAVE c
            int counter = 0;
            while (counter < 100)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //opgave d
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
