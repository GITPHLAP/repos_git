using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SQLLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Logik sqllogic = new Logik();
            Console.WriteLine("1 for opret bruger");
            Console.WriteLine("2 for login");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Skriv det ønskede brugernavn");
                    string usernameinput = Console.ReadLine();//Get userinput
                    Console.WriteLine("Skriv dit navn");
                    string nameinput = Console.ReadLine();//Get userinput
                    Console.WriteLine("Skriv den ønskede adgangskode");
                    string passwordinput = Console.ReadLine();//Get userinput
                    sqllogic.RegisterUser(usernameinput, nameinput, passwordinput);
                    break;
                case 2:
                    Console.WriteLine("Skriv dit brugernavn");
                    string loginusernameinput = Console.ReadLine(); //Get userinput
                    int usernamematch = sqllogic.CheckUsername(loginusernameinput);
                    switch (usernamematch)// switch between if there are an username there match
                    {
                        case 0:
                            Console.WriteLine("Der er ingen match med det indskrevet brugernavn");
                            break;
                        case 1:
                            bool loginsuccesfully = false;
                            int atempts = 1;
                            while (loginsuccesfully == false && atempts <= 3)
                            {
                                Console.WriteLine("Skriv dit adgangskode");
                                string userpasswordinput = Console.ReadLine();
                                int passwordmatch = sqllogic.CheckPassword(userpasswordinput, loginusernameinput);
                                switch (passwordmatch)
                                {
                                    case 0:
                                        Console.WriteLine("Din adgangskode virkede ikke prøv igen");
                                        break;
                                    case 1:
                                        loginsuccesfully = true; //Set the log on true if pasword match.
                                        Console.WriteLine("Logger ind.......");
                                        break;
                                    default:
                                        Console.WriteLine("Noget er galt ");
                                        break;
                                }
                                atempts++;// add 1 to tried atempts
                            }
                            if (loginsuccesfully == false)
                            {
                                    Console.WriteLine("Du har brugt for mange forsøg");
                                    Environment.Exit(1);//close the program if used to many atempts to log on
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            User logedonuser = sqllogic.Getuser();
            Console.WriteLine("Velkommen tilbage " + logedonuser.Name + "!!!");
            int userinput;
            switch (logedonuser.Rights)
            {
                case 1:
                    Console.WriteLine("Du har Adminstrator rettigheder.\r\n");
                    Console.WriteLine("1 for at ændre rettighed på bruger");
                    //Console.WriteLine("2 for at lave en ny tabel ");
                    //Console.WriteLine("3 for at indsætte data i den nye tabel");
                    userinput = Convert.ToInt32(Console.ReadLine()); //Get userinput
                    switch (userinput) //Make an switch for userinput
                    {
                        case 1:
                            Console.WriteLine("Skriv brugernavnet for brugeren du vil ændre rettigheder for");
                            string usernameinput = Console.ReadLine(); // get userinput
                            Console.WriteLine("Skriv rettighednummeret for brugeren du vil ændre rettigheder for");
                            int rightsinput = Convert.ToInt32(Console.ReadLine()); // get userinput
                            sqllogic.ChangeRights(usernameinput, rightsinput); // set userinput to method to change rights
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Du har læse og skrive rettigheder.\r\n");
                    Console.WriteLine("1 for at indsætte data om dig selv i person tabellen ");
                    userinput = Convert.ToInt32(Console.ReadLine()); //Get userinput
                    switch (userinput) //Make an switch for userinput
                    {
                        case 1:
                            Console.WriteLine("Skriv dit efternavn");
                            string lastname = Console.ReadLine(); // get userinput
                            Console.WriteLine("Skriv dit navn");
                            string name = Console.ReadLine(); // get userinput
                            Console.WriteLine("Skriv din adresse");
                            string adr = Console.ReadLine(); // get userinput
                            Console.WriteLine("Skriv dit mobil nummer");
                            string phone = Console.ReadLine(); // get userinput
                            Console.WriteLine("Skriv byen du bor i");
                            string city = Console.ReadLine(); // get userinput
                            sqllogic.InsertDataAboutUser(lastname, name, adr, city, phone, logedonuser.Id);
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Du har læse rettigheder.\r\n");
                    Console.WriteLine("1 for at se antal brugere");
                    userinput = Convert.ToInt32(Console.ReadLine()); //Get userinput
                    switch (userinput) //Make an switch for userinput
                    {
                        case 1:
                            List<string> uilistofusers = sqllogic.ReadAmountOfUsers();
                            foreach(var item in uilistofusers)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }


    }
}
