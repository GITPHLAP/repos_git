using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaskemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine wash = new WashingMachine();

            while (true)
            {
                Console.WriteLine("Vælg P for Power");
                Console.WriteLine("Vælg F for Fill");
                Console.WriteLine("Vælg W for Wash");
                Console.WriteLine("Vælg EW for Eco Wash");
                Console.WriteLine("Vælg S for Spin");

                string input = Console.ReadLine();
                switch (input) //laver en switch case udfra brugerens input
                {
                    case "P":

                        wash.turnonandoff();
                        break;
                    case "F":
                        wash.Filling();
                        break;
                    case "W":
                        wash.Washing();
                        break;
                    case "EW":
                        wash.EcoWashing();
                        break;
                    case "S":
                        wash.Spinning();
                        break;
                    default:
                        break;
                }


                Console.ReadLine();
            }
            
            
        }
    }
}
