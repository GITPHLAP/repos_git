using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Efter aftale med mikkel har vi lavet den her opgave istedet for
            //Declare variabler jeg skal bruge senere
            double resultaftermethod = 0;
            double number1 = 0;
            double number2 = 0;
            //Giver brugeren et valg for hvad der skal ske
            Console.WriteLine("Vælg mellem nedenstående:");
            Console.WriteLine("Tast 1: for at plus tal 1 med tal 2");
            Console.WriteLine("Tast 2: for at minus tal 1 med tal 2");
            Console.WriteLine("Tast 3: for at gange tal 1 med tal 2");
            Console.WriteLine("Tast 4: for at dividere tal 1 med tal 2");
            Console.WriteLine("Tast 5: for at kvadratrod tal 1 ");
            Console.WriteLine("Tast 6: for at opløft tal 1 med tal 2");
            Console.WriteLine("Tast 7: for Rest");
            int selected = int.Parse(Console.ReadLine());//bruger input
            //Valgmulighederne
            switch (selected)
            {
                case 1:
                    Console.WriteLine("Tal1 + Tal2");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());//bruger input
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = plus(number1, number2);//Resultatet hvor jeg kalder min metode
                    Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "+", number2, resultaftermethod);//udskriver resultatet med de værdiér som brugeren har skrevet
                    break;
                case 2:
                    Console.WriteLine("Tal1 + Tal2");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = minus(number1, number2);
                    Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "-", number2, resultaftermethod);
                    break;
                case 3:
                    Console.WriteLine("Tal1 + Tal2");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = gange(number1, number2);
                    Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "*", number2, resultaftermethod);
                    break;
                case 4:
                    Console.WriteLine("Tal1 + Tal2");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = dividere(number1, number2);
                    Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "/", number2, resultaftermethod);
                    break;
                case 5:
                    Console.WriteLine("Tal1 + Tal2");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = kvadratrod(number1);
                    Console.WriteLine("Resultatet af kvadratrod af{0} = {1}", number1, resultaftermethod);
                    break;
                case 6:
                    Console.WriteLine("Tal1 + Tal2");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = potens(number1, number2);
                    Console.WriteLine("Resultatet af {0} opløftet i {1} = {2}", number1, number2, resultaftermethod);
                    break;
                case 7:
                    Console.WriteLine("Find restenværdien ved tal1 af tal2 ");
                    Console.WriteLine("Skriv tal 1");
                    number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv tal 2");
                    number2 = int.Parse(Console.ReadLine());
                    resultaftermethod = moduls(number1, number2);
                    Console.WriteLine("Restværdien af {0} / {1} = {2}", number1, number2, resultaftermethod);
                    break;
                default:
                    break;
            }
        }
        //Mine metoder 
        public static double plus(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public static double minus(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public static double gange(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public static double dividere(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public static double potens(double num1, double num2)
        {
            double result = Math.Pow(num1, num2);
            return result;
        }
        public static double kvadratrod(double num1)
        {
            double result = Math.Sqrt(num1);
            return result;
        }
        public static double moduls(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }

    }
}
