using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        int aircraftCarrier = 0;
        int battleship = 0;
        int submarine = 0;
        int cruiser = 0;
        int destroyer = 0;
        private string playername;
        public Board playerboard = new Board();
        List<string> listofhitships = new List<string>();
        public string Playername
        {
            set
            {
                this.playername = value;
            }
            get
            {
                return playername;
            }
        }
        
        public Player()
        {
            playerboard.Addships();
        }
        public void SetShipPosition(int xposition, int yposition, string shipname, string direction)
        {
            playerboard.SetShipPosition(xposition, yposition, shipname, direction);
        }
        public bool EnableShipAndGrid(string name)
        {
            return playerboard.EnableShipAndGrid(name);
        }
        public string Checkfieldforships(int xposition, int yposition)
        {
            return playerboard.Checkfieldforships(xposition, yposition);
        }
        public void AddHitShipToCounter(string shipname)
        {
            switch (shipname)
            {
                case "aircraftCarrier":
                    aircraftCarrier++;
                    break;
                case "battleship":
                    battleship++;
                    break;
                case "submarine":
                    submarine++;
                    break;
                case "cruiser":
                    cruiser++;
                    break;
                case "destroyer":
                    destroyer++;
                    break;
                default:
                    break;
            }
        }
        public bool CheckIfOneShipIsSunk(string shipname)
        {
            if (shipname == "aircraftCarrier" && aircraftCarrier == 5)
            {
                return true;
            }
            else if (shipname == "battleship" && battleship == 4)
            {
                return true;
            }
            else if (shipname == "submarine" && submarine == 3)
            {
                return true;
            }
            else if (shipname == "cruiser" && cruiser == 3)
            {
                return true;
            }
            else if (shipname == "destroyer" && destroyer == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckIfAllShipIsSunk()
        {
            if (aircraftCarrier == 5 && battleship == 4 && submarine == 3 && cruiser == 3 && destroyer == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
