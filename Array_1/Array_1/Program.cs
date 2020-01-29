using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeg bruger den første løkke til at give mit array værdierne
            int[] arrwith9 = new int[9];
            for (int i = 0; i <= arrwith9.Length -1; i++)
            {
                arrwith9[i] = i+1;
                Console.WriteLine(arrwith9[i]);
            }

            // den her løkke finder jeg index nummer 5 som jeg synes er en mærkelig måde at finde det på
            for (int i = 0; i <= arrwith9.Length; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine(arrwith9[i]);
                    arrwith9[i] = arrwith9[i-1] * 2; // her skifter jeg værdien af index 5 til det dobbelte af index 4 
                    Console.WriteLine(arrwith9[i]);

                }

            }
        }
    }
}
