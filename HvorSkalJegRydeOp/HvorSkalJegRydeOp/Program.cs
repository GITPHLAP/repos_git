using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvorSkalJegRydeOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndtal = new Random();
            int tal = rndtal.Next(0, 10);

            
            Console.WriteLine(tal);
            Console.ReadLine();



        }
    }
}
