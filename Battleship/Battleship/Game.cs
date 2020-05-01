using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        private string shipdirection = "up";
        private bool isgamebegun = false;
        public Player player1 = new Player();
        Player player2 = new Player();
        private int whichturn = 0;

        public string Shipdirection
        {
            set
            {
                this.shipdirection = value;
            }
            get
            {
                return shipdirection;
            }
        }
        public bool Isgamebegun
        {
            set
            {
                this.isgamebegun = value;
            }
            get
            {
                return isgamebegun;
            }
        }
        public int Whichturn
        {
            get
            {
                return whichturn;
            }
        }

        public string Shoot(string typeofhit)
        {
            whichturn++;
            return typeofhit;
        }
        public string Checkfieldforships(int xposition, int yposition)
        {
            if (Whichturn % 2 == 0)
            {
                return player2.Checkfieldforships(xposition, yposition);//når det er player 1 tur skal den kigge i player 2 board
            }
            else
            {
                return player1.Checkfieldforships(xposition, yposition);//lige omvendt end player1
            }
        }
        public void SetShipPosition(int xposition, int yposition, string shipname, string playername)
        {
            if (playername == "player1")
            {
                player1.SetShipPosition(xposition, yposition, shipname, shipdirection);
            }
            else
            {
                player2.SetShipPosition(xposition, yposition, shipname, shipdirection);
            }
        }
        public bool EnableShipAndGrid(string name, string playername)
        {
            if (playername == "player1")
            {
                return player1.EnableShipAndGrid(name);
            }
            else
            {
                return player2.EnableShipAndGrid(name);

            }
        }
        public void AddHitShipToCounter(string shipname)
        {
            if (Whichturn % 2 == 0)
            {
                player2.AddHitShipToCounter(shipname);
            }
            else
            {
                player1.AddHitShipToCounter(shipname);
            }
        }
        public bool CheckIfOneShipIsSunk(string shipname)
        {
            if (Whichturn % 2 == 0)
            {
                return player2.CheckIfOneShipIsSunk(shipname);
            }
            else
            {
                return player1.CheckIfOneShipIsSunk(shipname);
            }
        }
        public bool CheckIfAllShipIsSunk()
        {
            if (Whichturn % 2 == 0)
            {
                return player2.CheckIfAllShipIsSunk();
            }
            else
            {
                return player1.CheckIfAllShipIsSunk();
            }
        }
        public void SetShipdirection(string direction)
        {
            shipdirection = direction;
        }
    }
}
