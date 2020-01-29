using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TestTilLommeregnerMedHistorie
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input;
            //input = Console.ReadLine();
            //NumberValidater.Validater(input);


            

            textinput("dato", "udregning", "resultat", "kage.csv");

            //Console.ReadLine();
        }
        public static void textinput(string date, string calculation, string result, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter w2file = new StreamWriter(@filepath, true))
                {
                    w2file.WriteLine(date + ";" + calculation + ";" + result);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException("oopsi:) Something went wrong:", ex);
            }
        }
    }
}
