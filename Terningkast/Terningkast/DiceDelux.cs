using System;
using System.Collections.Generic;
using System.Text;

namespace Terningkast
{
    public class DiceDelux
    {
        public static void Deluxthrow() 
        { 
            //opret en randomizer til at vælge et terning kast
            Random ranToDice = new Random();
            int DiceInt = ranToDice.Next(1, 7);
            Console.WriteLine($"Du slog {DiceInt}'er");
        }
    }
}