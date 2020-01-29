using System;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv længden i cm");
            double lengthinput = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv bredden i cm");
            double widthinput = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv højden i cm");
            double highinput = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv vægt i gram");
            double weightinput = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv landet (Danmark)");
            string countryinput = Console.ReadLine();

            //Begynder at validere om input er gyldigt
            //under hver if bliver der skrevet til brugeren et svar enten med en pris eller med en fejl besked om input ikke er valid
            if (lengthinput > 120 && (lengthinput + (lengthinput * widthinput * highinput)) > 300 && weightinput > 35000)
            {
                Console.WriteLine("Dit input er enten for tungt eller for stort"); //skriver fejl besked til bruger
            }
            else// hvis den er i de rigtige formater begynder beregningen
            {
                if (countryinput == "Danmark")
                {
                    if (lengthinput <= 60 && (lengthinput + widthinput + highinput) <= 90 && weightinput <= 2000)//hvis sandt så er det et brev
                    {
                        if (weightinput <= 50)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 10 kr");
                        }
                        else if (weightinput > 250)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 60 kr");
                        }
                        else if (weightinput > 100)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 40 kr");
                        }
                        else if (weightinput > 50)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 20 kr");
                        }
                    }
                    else//Det er en pakke
                    {
                        if (weightinput > 20000)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 160 kr");
                        }
                        else if (weightinput > 10000)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 100 kr");
                        }
                        else if (weightinput > 5000)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 80 kr");
                        }
                        else if (weightinput > 2000)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 60 kr");
                        }
                        else if (weightinput > 0)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 50 kr");
                        }
                    }
                }
                else //Det er et andet land end danmark
                {
                    if (lengthinput <= 60 && (lengthinput + widthinput + highinput) <= 90 && weightinput <= 2000)//hvis sandt så er det et brev
                    {
                        if (weightinput > 250)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 90 kr");
                        }
                        else if (weightinput > 100)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 60 kr");
                        }
                        else if (weightinput > 0)
                        {
                            Console.WriteLine("Prisen for at sende dit brev bliver 30 kr");
                        }
                    }
                    else//Det er en pakke
                    {
                        
                        if (weightinput > 20000)
                        {
                            Console.WriteLine("Man kan ikke sende en pakke på mere end 20kg");
                        }
                        else if (weightinput > 15000)
                        {
                            Console.WriteLine("Prisen for at sende dit pakke bliver 1648 kr");
                        }
                        else if (weightinput > 10000)
                        {
                            Console.WriteLine("Prisen for at sende dit pakke bliver 1244 kr");
                        }
                        else if (weightinput > 5000)
                        {
                            Console.WriteLine("Prisen for at sende dit pakke bliver 840 kr");
                        }
                        else if (weightinput > 1000)
                        {
                            Console.WriteLine("Prisen for at sende dit pakke bliver 517 kr");
                        }
                        else if (weightinput > 0)
                        {
                            Console.WriteLine("Prisen for at sende dit pakke bliver 275 kr");
                        }
                    }
                }
            }
        }
    }
}
