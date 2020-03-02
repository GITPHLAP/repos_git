using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle allbattles = new Battle();

            allbattles.AddAllCharacters();
            allbattles.Addallfights();
            allbattles.AddWinnerCharacterTonextFight();
            allbattles.BeginFinal();
        }
    }
}
