using System;

namespace Morsekoden
{
    class Program
    {
        static void Main(string[] args)
        {
            //spørg brugeren om input
            Console.WriteLine("Skriv den tekst du vil have oversæt");
            string inputtext = Console.ReadLine();

            char[] texttoChar = inputtext.ToLower().ToCharArray(); //først ændre jeg input til små bogstaver derefter laver jeg det til et char[]
            string outputstring = ""; //declare jeg output texten

            for (int i = 0; i < texttoChar.Length; i++) //jeg sætter loop til at køre så længe der er karaktere i mit array
            {
                switch (texttoChar[i])
                {
                    //A .- 
                    case 'a':
                        outputstring += ".- "; //jeg tilføjer en værdi til mit output
                        break;
                    //B -... 
                    case 'b':
                        outputstring += "-... ";
                        break;
                    //C -.-. 
                    case 'c':
                        outputstring += "-.-. ";
                        break;
                    //D -.. 
                    case 'd':
                        outputstring += "-.. ";
                        break;
                    //E . 
                    case 'e':
                        outputstring += ". ";
                        break;
                    //F ..- 
                    case 'f':
                        outputstring += "..- ";
                        break;
                    //g --. 
                    case 'g':
                        outputstring += "-- ";
                        break;
                    //H .... 
                    case 'h':
                        outputstring += ".... ";
                        break;
                    //I .. 
                    case 'i':
                        outputstring += ".. ";
                        break;
                    //J .--- 
                    case 'j':
                        outputstring += ".--- ";
                        break;
                    //K -.- 
                    case 'k':
                        outputstring += "-.- ";
                        break;
                    //L .-.. 
                    case 'l':
                        outputstring += ".-.. ";
                        break;
                    //M -- 
                    case 'm':
                        outputstring += "-- ";
                        break;
                    //N -. 
                    case 'n':
                        outputstring += "-. ";
                        break;
                    //O --- 
                    case 'o':
                        outputstring += "--- ";
                        break;
                    //P .--. 
                    case 'p':
                        outputstring += ".-- ";
                        break;
                    //Q --.- 
                    case 'q':
                        outputstring += "--.- ";
                        break;
                    //R .-. 
                    case 'r':
                        outputstring += ".-. ";
                        break;
                    //S ... 
                    case 's':
                        outputstring += "... ";
                        break;
                    //T - 
                    case 't':
                        outputstring += "- ";
                        break;
                    //U ..- 
                    case 'u':
                        outputstring += "..- ";
                        break;
                    //V ...- 
                    case 'v':
                        outputstring += "...- ";
                        break;
                    //W .-- 
                    case 'w':
                        outputstring += ".-- ";
                        break;
                    //x -..- 
                    case 'x':
                        outputstring += "-..- ";
                        break;
                    //y -.-- 
                    case 'y':
                        outputstring += "-.-- ";
                        break;
                    //Z --.. 
                    case 'z':
                        outputstring += "--.. ";
                        break;
                    //Æ .-.- 
                    case 'æ':
                        outputstring += ".-.- ";
                        break;
                    //Ø ---. 
                    case 'ø':
                        outputstring += "---. ";
                        break;
                    //Å .--.-
                    case 'å':
                        outputstring += ".--.- ";
                        break;
                    default:
                        Console.WriteLine("Virker ikke");
                        break;
                }
                

            }
            Console.WriteLine(outputstring); //jeg udskriver mit output
        }
    }
}
