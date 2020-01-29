using System;

namespace Arrays_opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,,,,] tabel = new float[5, 5, 5, 5, 5]; //Jeg laver et todimensionelt array på på 5 rækker og 5 kolonner
            int counter = 1;
            //dette for-loop bliver brugt til at indsætte værdierne i arrayet.
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tabel[i, j, i, j, i] = counter;
                    counter++;                    
                }
            }
            //Dette for loop bliver brugt til at udskrive i det som en tabel
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tabel[i, j, i, j, i] + "      ");
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
