using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTilLommeregnerMedHistorie
{
    class NumberValidater
    {
        public static void Validater( string inputFromProgram)
        {
            double inputAsDouble;
            bool inputAsBool;
            inputAsBool = double.TryParse(inputFromProgram, out inputAsDouble);
            
            if (inputAsBool)
            {
                Console.WriteLine(inputAsDouble);
            }
            else
            {
                Console.WriteLine("Det er ikke gyldigt input :)");
            }
            
        }
    }
}
