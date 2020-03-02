using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Arena
{
    class Character
    {
        private string name;
        private int hitpoints;
        private int minattack;
        private int maxattack;
        private int mindefence;
        private int maxdefence;

        static int karlcount = 0;

        public string Name
        {
            set 
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public int Hitpoints
        {
            set
            {
                this.hitpoints = value;
            }
            get
            {
                return hitpoints;
            }
        }
        public int MinAttack
        {
            set
            {
                this.minattack = value;
            }
            get
            {
                return minattack;
            }
        }
        public int MaxAttack
        {
            set
            {
                this.maxattack = value;
            }
            get
            {
                return maxattack;
            }
        }
        public int MinDefence
        {
            set
            {
                this.mindefence = value;
            }
            get
            {
                return mindefence;
            }
        }
        public int MaxDefence
        {
            set
            {
                this.maxdefence = value;
            }
            get
            {
                return maxdefence;
            }
        }


        public Character()
        {

        }
        public Character(string charactername, int characterhitpoint, int characterminattack, int charactermaxattack, int charactermindefence, int charactermaxdefence)
        {
            this.name = charactername;
            this.hitpoints = characterhitpoint;
            this.minattack = characterminattack;
            this.maxattack = charactermaxattack;
            this.mindefence = charactermindefence;
            this.maxdefence = charactermaxdefence;
        }


        public int DefenceRange()
        {
            Random randomnum = new Random();
            int defencerange = randomnum.Next(this.mindefence, this.maxdefence + 1);
            return defencerange;

        }
        public int AttackRange()
        {
            if (this.name == "Hurtig Karl")
            {
                if (karlcount % 2 == 0)
                {
                    karlcount++;
                    return 5;
                }
                else
                {
                    karlcount++;
                    return 2;
                }
            }
            else
            {
                Random randomnum = new Random();
                int attackrange = randomnum.Next(this.minattack, this.maxattack + 1);
                return attackrange;
            }
        }
    }
}
