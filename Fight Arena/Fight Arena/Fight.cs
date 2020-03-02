using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Arena
{
    class Fight
    {
        private Character firstcharacter;
        private Character secondcharacter;
        Character charactertocallmethod = new Character();

        public Character Firstcharacter
        {
            set
            {
                this.firstcharacter = value;
            }
            get
            {
                return firstcharacter;
            }
        }
        public Character Secondcharacter
        {
            set
            {
                this.secondcharacter = value;
            }
            get
            {
                return secondcharacter;
            }
        }
        public Fight()
        {

        }
        public Fight(Character firstone, Character secondone)
        {
            this.firstcharacter = firstone;
            this.secondcharacter = secondone;
        }


        public Character BeginFight(string whichbattle)
        {
            int firstCharacterHitpoint = firstcharacter.Hitpoints;
            int secondCharacterHitpoint = secondcharacter.Hitpoints;
            int countrounds = 0;
            Console.WriteLine(whichbattle + " begynder nu!");
            do
            {
                int secondchardefence = secondcharacter.DefenceRange();
                int firstcharattack = firstcharacter.AttackRange();
                if ((secondchardefence - firstcharattack) <= 0)
                {
                    secondCharacterHitpoint += (secondchardefence - firstcharattack);
                    if (secondcharacter.Name == "Katten Tiger" && countrounds <= 9)
                    {
                        secondCharacterHitpoint += 3;
                        Console.WriteLine("Katten Tiger får +3 hitpoints fordi han er en kat:)");
                    }
                    Console.WriteLine(secondcharacter.Name + " har " + secondCharacterHitpoint + " liv tilbage");

                }
                else
                {
                    Console.WriteLine("Angrebet var ikke stærkt nok så der skete ingenting");
                }

                int secondcharattack = secondcharacter.AttackRange();
                int firstchardefence = firstcharacter.DefenceRange();
                if ((firstchardefence - secondcharattack) <= 0)
                {
                    firstCharacterHitpoint += (firstchardefence - secondcharattack);
                    if (firstcharacter.Name == "Katten Tiger" && countrounds <= 9)
                    {
                        firstCharacterHitpoint += 3;
                        Console.WriteLine("Katten Tiger får +3 hitpoints fordi han er en kat:)");
                    }
                    Console.WriteLine(firstcharacter.Name + " har " + firstCharacterHitpoint + " liv tilbage");
                }
                else
                {
                    Console.WriteLine("Angrebet var ikke stærkt nok så der skete ingenting");
                }
                countrounds++;
            } while (firstCharacterHitpoint > 0 && secondCharacterHitpoint > 0 );
            if (firstCharacterHitpoint <= 0)
            {
                Console.WriteLine(secondcharacter.Name + " Vandt " + whichbattle);
                return secondcharacter;
            }
            else if (secondCharacterHitpoint <= 0)
            {
                Console.WriteLine(firstcharacter.Name + " Vandt " + whichbattle);
                return firstcharacter;
            }
            else
            {
                Console.WriteLine("Noget gik galt");
                return null;
            }
        }

    }
}
