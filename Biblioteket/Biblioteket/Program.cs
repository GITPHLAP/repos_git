using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> usersStack = new List<Book>();//laver en liste "inkøbskurv"
            Stack<string> usersbooks = new Stack<string>();//laver en bunke med bøger på skranken
            Book logic = new Book();
            logic.addbooks();//tilføjer alle b'ger
            while (true)
            {
                Console.WriteLine("[1]find bøger [2]Lån bøger [3]Se resten af bøgerne ");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        logic.seeall();
                        Console.WriteLine("Skriv navnet på den bog du vil låne");
                        string inputname = Console.ReadLine();

                        Book LendBookToUser = logic.Lendbooks(inputname);//kalder metoden til at finde boge man har søgt efter
                        if (LendBookToUser != null)
                        {
                            usersStack.Add(LendBookToUser);//tilføjer den til kurven
                        }
                        break;
                    case "2":
                        
                        movebook();//flytter alle bøger fr kurven til skranken

                        for (int i = 0; i <= usersbooks.Count; i++)//for hvergang der er et element i køen skal den udskrive hvad bogen hedder
                        {
                            Console.WriteLine( "Næste bog til at scanne hedder: " + usersbooks.Peek());
                            usersbooks.Pop(); //her er den skannet og fjernet fra køen

                        }
                        

                        break;
                    case "3":
                        logic.seeall();//metode til at se alle resterenede bøger
                        break;
                    default:
                        break;
                }
                


                Console.ReadLine();
            }
            void movebook()//metode til at flytte bøgerne fra inkøbskurv til skranke
            {

                foreach (var item in usersStack)
                {

                    usersbooks.Push(item.name);//Tilføjer listens navn til køen
                }

                        usersStack.Clear();//fjerne alt fra "inkøbskurven"

                

                }
            }
        }
    }
