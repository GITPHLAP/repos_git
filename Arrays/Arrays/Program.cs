    using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool knowusername = false; // tjekker om navn er kendt
            bool knowpassword = false; // tjekker om password er kendt
            //indsætter værder til array
            string[] usernamearr = new string[5];
            usernamearr[0] = "navn0";
            usernamearr[1] = "navn1";
            usernamearr[2] = "navn2";
            usernamearr[3] = "navn3";
            usernamearr[4] = "navn4";
            string[] passwordarr = new string[5];
            passwordarr[0] = "pass0";
            passwordarr[1] = "pass1";
            passwordarr[2] = "pass2";
            passwordarr[3] = "pass3";
            passwordarr[4] = "pass4";
            Console.WriteLine("Skriv dit brugernavn");
            string usernameinput = Console.ReadLine();//bruger input username
            int checkusernamewithpassword = 0;
            string passwordinput = "";
            //tjekker navn
            for (int i = 0; i <= usernamearr.Length -1; i++)
            {
                if (usernamearr[i] == usernameinput)
                {
                    knowusername = true;
                    checkusernamewithpassword = i;//hvis navn er sandt sætter den indexværdien så jeg kan matche password
                }
                
            }

            if (knowusername == true)
            {
                Console.WriteLine("Skriv dit password");//du skal skrive password
                passwordinput = Console.ReadLine();
                int counter = 1;//sat til 1 fordi der allerede er brugt et forsøg
                if (passwordinput == passwordarr[checkusernamewithpassword])
                {
                    knowpassword = true;
                }
                while (knowpassword==false && counter <= 2)// man har 3 forsøg
                {
                    Console.WriteLine("Forkert password, skriv dit password igen");
                    passwordinput = Console.ReadLine();
                    if (passwordinput == passwordarr[checkusernamewithpassword])
                    {
                        knowpassword = true;
                    }
                    counter++;
                }
                if (knowpassword == true)
                {
                    Console.WriteLine("Du har adgang til systemet");//du er godkendt
                }
                else
                {
                    Console.WriteLine("Fejl du har ikke adgang");//du bliver lukket af
                    return;
                }
            }

        }
    }
}
