using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();//laver min maskine
            while (true)//køre mit program heletiden
            {
                Console.WriteLine("[admin] for adminstration");
                Console.WriteLine("[1] for at købe");
                string userinput = Console.ReadLine();//læser bruger input
                switch (userinput)
                {
                    case "admin"://hvis der bliver skrevet admin kan adminstrere automaten
                        bool countinueadmin = true;
                        do
                        {
                            Console.WriteLine("[1] for at se alt i automaten");
                            Console.WriteLine("[2] for at genopfylde alle varne igen");
                            Console.WriteLine("[3] for at tømme boksen med penge");
                            Console.WriteLine("[4] juster priserne");
                            Console.WriteLine("[exit]");
                            string userinputforadmin = Console.ReadLine();
                            switch (userinputforadmin)
                            {
                                case "1":
                                    machine.Showall();//kalder metoden til at vise alle produkter 
                                    break;
                                case "2":
                                    machine.Refill();//genopfylder vare
                                    break;
                                case "3":
                                    machine.CollecttheMoney();//indsamler penge
                                    break;
                                case "4":
                                    Console.WriteLine("Hvad vil du ændre prisen på");
                                    Console.WriteLine("[lollypop] slikkepind");
                                    Console.WriteLine("[cornybar] Cornybar");
                                    Console.WriteLine("[colasoda] Haribo Cola");
                                    string adminpickproduct = Console.ReadLine();//læser input for at se hvilket product der skal ændres pris på
                                    Console.WriteLine("indtast nu prisen");
                                    int newprice = int.Parse(Console.ReadLine());//indsætter en ny pris
                                    machine.ChangePrice(adminpickproduct, newprice);//ændre prisen
                                    break;
                                case "exit":
                                    countinueadmin = false;//går ud af adminstration
                                    break;
                                default:
                                    break;
                            }
                        } while (countinueadmin);
                        break;
                    case "1"://køb
                        Console.WriteLine("Hvad vil du købe");
                        Console.WriteLine("[lollypop] slikkepind");
                        Console.WriteLine("[cornybar] Cornybar" );
                        Console.WriteLine("[colasoda] Haribo Cola");
                        Console.WriteLine("Du kan altid [afslut] dit køb");
                        string pickproduct = Console.ReadLine();
                        if (pickproduct == "lollypop" || pickproduct == "colasoda" || pickproduct == "cornybar" || pickproduct == "afslut")//hvis der ikke bliver indtastet et af følgende bliver det ikke godkendt
                        {
                            if (pickproduct == "afslut")//hvis der bliver skrevet afslut lukker programmet
                            {
                                return;
                            }
                            machine.Seeproduct(pickproduct);//ser det valgte produkt
                            int price = machine.SetPriceToVariable(pickproduct); //giver en local variable productets pris værdi
                            Console.WriteLine("indsæt dine penge");
                            string exitbuyingandcheckcoin = Console.ReadLine();//læser bruger input
                            if (exitbuyingandcheckcoin == "afslut")//hvis der blev skrevet afslut lukker den programmet
                            {
                                return;
                            }
                            CheckCoin(exitbuyingandcheckcoin);//tjekker om det er en godkendt mønt
                            int insertedmoney = int.Parse(exitbuyingandcheckcoin);//konverter mønten om til noget der kan regnes med
                            while (insertedmoney != price)//hvis insættede penge ikke matcher med prisen gør den følgende
                            {
                                if (insertedmoney < price)//hvis indsættede penge er mindre sker følgende
                                {
                                    Console.WriteLine("ikke penge nok smid flere i");
                                    exitbuyingandcheckcoin = Console.ReadLine();//bruger input
                                    if (exitbuyingandcheckcoin == "afslut")//hvis input er afslut returner det allerede indkastede mønter og lukker programmet
                                    {
                                        Console.WriteLine("du har afsluttede handlen");
                                        Console.WriteLine("Du får " + insertedmoney + " kr. retur");
                                        Console.ReadLine();
                                        return;
                                    }
                                    CheckCoin(exitbuyingandcheckcoin);//tjekker om det er en gyldig mønt
                                    insertedmoney += int.Parse(exitbuyingandcheckcoin);//ellers tilføjer den det nye indkastede kønter til det gamle og tjekker igen
                                }
                                else if (insertedmoney > price)//hvis indsættede mønter er større sker følgende
                                {
                                    int moneyback = insertedmoney - price; //trækker indkastede mønter fra prisen
                                    Console.WriteLine("Du har smidt for mange penge i.");
                                    Console.WriteLine("Du får " + moneyback + " kr. tilbage og en");//sender penge tilbage

                                    insertedmoney -= moneyback;//trækker moneyback fra insertedmoney så insertedmoney bliver det samme som prisen så programmet kan køre videre

                                }
                                else//ellers kontakt teknikeren
                                {
                                    Console.WriteLine("Kontakt en tekniker, noget gik galt med automaten");
                                }
                            }
                            if (insertedmoney == price)//hvis indkastede mønter er det samme som prisen
                            { 
                                Console.WriteLine(machine.Buyone(pickproduct).Name + " ligger i skuffen klar til at du kan nyde den :)");
                            }
                            else//ellers er der sket en fejl og en tekniker på se på det
                            {
                                Console.WriteLine("Kontakt en tekniker, noget gik galt med automaten");
                            }
                        }
                        else//hvis input ikke stemte overens
                        {
                            Console.WriteLine("dit input var ugyldigt");
                        }                    
                        break;
                    default:
                        break;
                }

                Console.ReadLine();

            }
        }

        private static void CheckCoin(string money)//metode til at tjekke om input er en mynt
        {
            if (money != "1" || money != "2" || money != "5" || money != "10" || money != "20")//hvis den ikke er nogen kendt mønt sker der dette
            {
                Console.WriteLine("Dit input er ikke en mønt");
                Environment.Exit(1); //lukker programmet hvis der bliver smidt forkert valuta i
                
            }

        }
    }
}
