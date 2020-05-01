using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        string name;
        int size;
        public int Size
        {
            set
            {
                this.size = value;
            }
            get
            {
                return size;
            }
        }
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
        public Ship()
        {

        }
        public Ship(int size, string name)
        {
            this.size = size;
            this.name = name;
        }
    }
}
