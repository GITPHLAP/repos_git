using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctcounter = 0;
            do
            {
                correctcounter = 0;
                int[] WinnerLotto = new int[7]; //vinder kupon
                int[] userLotto = new int[7]; //User lotto kupon

                Random rndnum = new Random();

                //Dette for-loop er til vinder kupon'en
                for (int i = 0; i <= WinnerLotto.Length - 1; i++)
                {
                    int rndWinNumLotto = rndnum.Next(1, 21);
                    WinnerLotto[i] = rndWinNumLotto;
                }

                //Dette for loop er til brugerens kupon
                for (int j = 0; j <= userLotto.Length - 1; j++)
                {
                    int rnduserNumToLotto = rndnum.Next(1, 21);
                    userLotto[j] = rnduserNumToLotto;
                }
                //Tæller antal rigtige
                
                for (int k = 0; k <= WinnerLotto.Length - 1; k++)
                {
                    if (WinnerLotto[k] == userLotto[k])
                    {
                        correctcounter++;
                    }
                }
                Console.WriteLine($"Du har {correctcounter} tal som passer med vinder kupon'en");//antal rigtige tal
                                                                                                 //Disse if sætninger er gevindterne
                if (correctcounter < 2)
                {
                    Console.WriteLine("Du har under 2 rigtige tal, så der er ingen gevinster til dig!");
                }
                else if (correctcounter == 7)
                {
                    Console.WriteLine("Du har alle rigtige og vinder 3 timers hjemme arbejde");
                }
                else if (correctcounter == 6)
                {
                    Console.WriteLine("Tillykke du har 6!");
                }
                else if (correctcounter == 5)
                {
                    Console.WriteLine("Tillykke du har 5 rigtige og har vundet en kubikmeter luft");
                }
                else if (correctcounter == 4)
                {
                    Console.WriteLine("Tillykke du har 4 rigtige og har fortjent et kompliment... Flotte sokker!");
                }
                else if (correctcounter == 3)
                {
                    Console.WriteLine("Du har 3 rigtige og har vundet et gratis kram... Så her er der et virtuelt kram ");
                }
            } while (correctcounter != 7);

        }
    }
}
