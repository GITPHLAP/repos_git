using System;
using System.Collections.Generic;
using System.Text;

namespace Terningkast
{
    class ColorDize
    {
        public static void Colorthrow()
        {
            //opret en randomizer til at vælge et terning kast
            Random ranToDice = new Random();
            int DiceInt = ranToDice.Next(1, 7);
            //De her    statements er til at fortælle hvad der skal skrives til konsolen alt efter hvilket tal "terningen lander på"
            if (DiceInt == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red; //valg af baggrund farve
                Console.ForegroundColor = ConsoleColor.White; //valg af tekst farve
                Console.WriteLine("Du slog en 1'er"); //udskrives
            }
            else if (DiceInt == 2)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Du slog en 2'er");
            }
            else if (DiceInt == 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Du slog en 3'er");
            }
            else if (DiceInt == 4)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Du slog en 4'er");
            }
            else if (DiceInt == 5)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Du slog en 5'er");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Du slog en 6'er");
            }
            Console.ResetColor();
        }
    }
}
