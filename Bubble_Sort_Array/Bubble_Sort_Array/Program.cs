using System;

namespace Bubble_Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPGAVE A
            //Bruges til at oprette et
            Random rndnumbers = new Random();
            

            int[] numbersinarr = new int[100];
            for (int i = 0; i <= numbersinarr.Length -1; i++)
            {
                int RNum2A = rndnumbers.Next(1, 101);
                numbersinarr[i] = RNum2A;
                Console.WriteLine(numbersinarr[i]);
            }


            //OPGAVE B
            int numbertemp = 0;
            for (int i = 0; i <= numbersinarr.Length -1; i++)
            {
                for (int j = 1; j <= numbersinarr.Length -1; j++)
                {
                    if (numbersinarr[j-1] > numbersinarr[j])
                    {
                        numbertemp = numbersinarr[j];
                        numbersinarr[j] = numbersinarr[j - 1];
                        numbersinarr[j - 1] = numbertemp;
                    }
                }
            }
            Console.Write(Environment.NewLine + "Bubble Sort" + Environment.NewLine + Environment.NewLine);
            for (int i = 0; i <= numbersinarr.Length -1; i++)
            {
                Console.WriteLine(numbersinarr[i]);
            }


            //OPGAVE C
            Console.Write(Environment.NewLine + "Revers Sort" + Environment.NewLine + Environment.NewLine);

            
            Array.Reverse(numbersinarr);
            for (int i = 0; i <= numbersinarr.Length -1; i++)
            {
                Console.WriteLine(numbersinarr[i]);
            }
        }
    }
}