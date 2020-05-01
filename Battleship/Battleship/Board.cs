using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board
    {
        public string[,] fieldcontaine = new string[10, 10];
        List<Ship> ships = new List<Ship>();



        public void Addships()
        {
            ships.Add(new Ship(5, "aircraftCarrier"));
            ships.Add(new Ship(4, "battleship"));
            ships.Add(new Ship(3, "submarine"));
            ships.Add(new Ship(3, "cruiser"));
            ships.Add(new Ship(2, "destroyer"));
        }
        public void SetShipPosition(int xposition, int yposition, string shipname, string direction)
        {
            switch(direction)
            {
                case "up":
                    foreach (var item in ships)
                    {
                        if (item.Name == shipname)
                        {
                            for (int i = 0; i < item.Size; i++)
                            {
                                fieldcontaine[xposition, yposition-i] = shipname;
                            }
                            item.Size = 0;
                        }
                    }
                    break;
                case "left":
                    foreach (var item in ships)
                    {
                        if (item.Name == shipname)
                        {
                            for (int i = 0; i < item.Size; i++)
                            {
                                fieldcontaine[xposition -i, yposition] = shipname;
                            }
                            item.Size = 0;
                        }
                    }
                    break;
                case "right":
                    foreach (var item in ships)
                    {
                        if (item.Name == shipname)
                        {
                            for (int i = 0; i < item.Size; i++)
                            {
                                fieldcontaine[xposition + i, yposition] = shipname;
                            }
                            item.Size = 0;
                        }
                    }
                    break;
                case "down":
                    foreach (var item in ships)
                    {
                        if (item.Name == shipname)
                        {
                            for (int i = 0; i < item.Size; i++)
                            {
                                fieldcontaine[xposition, yposition + i] = shipname;
                            }
                            item.Size = 0;
                        }
                    }
                    break;
            }
            
            

        }
        public bool EnableShipAndGrid(string name)
        {
            foreach (var item in ships)
            {
                if (item.Name == name && item.Size == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public string Checkfieldforships(int xposition, int yposition)
        {
            return fieldcontaine[xposition, yposition];
        }
        
    }
}
