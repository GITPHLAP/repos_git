using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Arena
{
    class Battle
    {
        Dictionary<string, Fight> fights = new Dictionary<string, Fight>();

        List<Character> characters = new List<Character>();



        public void AddAllCharacters()
        {
            characters.Add(new Character("Kong Fu Harry", 120, 2, 2, 5, 5));
            characters.Add(new Character("Super hunden Dino", 70, 6, 8, 2, 8));
            characters.Add(new Character("Hurtig Karl", 90, 2, 5, 3, 3));
            characters.Add(new Character("Gift Gunner", 90, 1, 13, 5, 5));
            characters.Add(new Character("Minimusen Mikkel", 40, 9, 9, 9, 9));
            characters.Add(new Character("Katten Tiger", 35, 3, 6, 4, 4));
            characters.Add(new Character("Gummigeden Ivan", 70, 6, 6, 8, 8));
            characters.Add(new Character("Elgen Egon", 90, 5, 11, 4, 4));
        }
        public void Addallfights()
        {
            fights.Add("quartfinal1", new Fight(characters[0],characters[1]));
            fights.Add("quartfinal2", new Fight(characters[2], characters[3]));
            fights.Add("quartfinal3", new Fight(characters[4], characters[5]));
            fights.Add("quartfinal4", new Fight(characters[6], characters[7]));
        }
        public void AddWinnerCharacterTonextFight()
        {
            fights.Add("Semifinal1", new Fight(fights["quartfinal1"].BeginFight("Første Kvartfinale"), fights["quartfinal2"].BeginFight("Anden k" +
                "vartfinale")));
            fights.Add("Semifinal2", new Fight(fights["quartfinal3"].BeginFight("Trejde kvartfinale"), fights["quartfinal4"].BeginFight("Sidste kvartfinale")));

            fights.Add("Final", new Fight(fights["Semifinal1"].BeginFight("Første semifinale"), fights["Semifinal2"].BeginFight("Anden semifinale")));


        }
        public void BeginFinal()
        {
            fights["Final"].BeginFight("Finalen");
        }
    }
}
