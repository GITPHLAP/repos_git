using System;
using System.Text;

namespace Metoder_Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                
                //Efter aftale med mikkel har vi lavet den her opgave istedet for
                double number1 = 0;
                double number2 = 0;
                double resultaftermethod = 0;
                //udskriver  valgmuligheder som brugeren har
                Console.WriteLine("Vælg mellem nedenstående:");
                Console.WriteLine("Tast 1: for at plus tal 1 med tal 2");
                Console.WriteLine("Tast 2: for at minus tal 1 med tal 2");
                Console.WriteLine("Tast 3: for at gange tal 1 med tal 2");
                Console.WriteLine("Tast 4: for at dividere tal 1 med tal 2");
                Console.WriteLine("Tast 5: for at kvadratrod af tal 1 ");
                Console.WriteLine("Tast 6: for at opløft tal 1 med tal 2");
                Console.WriteLine("Tast 7: for Rest");
                int selected = int.Parse(Console.ReadLine());

                //Her vælger den ud fra hvilket input brugeren har skrevet hvad der skal gøres
                switch (selected)
                {
                    case 1:
                        Console.WriteLine("Tal1 + Tal2");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv tal 2");
                        number2 = double.Parse(Console.ReadLine());
                        resultaftermethod = plus(number1, number2);
                        Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "+", number2, resultaftermethod);
                        break;
                    case 2:
                        Console.WriteLine("Tal1 - Tal2");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv tal 2");
                        number2 = double.Parse(Console.ReadLine());
                        resultaftermethod = minus(number1, number2);
                        Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "-", number2, resultaftermethod);
                        break;
                    case 3:
                        Console.WriteLine("Tal1 * Tal2");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv tal 2");
                        number2 = double.Parse(Console.ReadLine());
                        resultaftermethod = gange(number1, number2);
                        Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "*", number2, resultaftermethod);
                        break;
                    case 4:
                        Console.WriteLine("Tal1 / Tal2");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv tal 2");
                        number2 = double.Parse(Console.ReadLine());
                        resultaftermethod = dividere(number1, number2);
                        Console.WriteLine("Resultatet af {0} {1} {2} = {3}", number1, "/", number2, resultaftermethod);
                        break;
                    case 5:
                        Console.WriteLine("skriv tallet du vil tag kvadratroden af!");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        resultaftermethod = kvadratrod(number1);
                        Console.WriteLine("Resultatet af {2}{0} = {1}", number1, resultaftermethod, Convert.ToChar(0x221A));
                        break;
                    case 6:
                        Console.WriteLine("(tal1 opløftet i tal2)       Tal1^Tal2");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv tal 2");
                        number2 = double.Parse(Console.ReadLine());
                        resultaftermethod = potens(number1, number2);
                        Console.WriteLine("Resultatet af {0}{1}{2} = {3}", number1, "^", number2, resultaftermethod);
                        break;
                    case 7:
                        Console.WriteLine("Find restværdien ved tal1 af tal2 ");
                        Console.WriteLine("Skriv tal 1");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv tal 2");
                        number2 = double.Parse(Console.ReadLine());
                        resultaftermethod = moduls(number1, number2);
                        Console.WriteLine("Resultatet af resten af: {0} {1} {2} = {3}", number1, "/", number2, resultaftermethod);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        //Her declare jeg alle metoderne jeg bruger til at udregning
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
