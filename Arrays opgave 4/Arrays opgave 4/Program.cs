using System;

namespace Arrays_opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] class1 = { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander" };
            string[] class2 = {"Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias"};
            float[,] puntuations = new float[10, 10];
            float AVG= 0;
            float AVGclass2 = 0;
            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine("Enter karakter {0} group {1}", class1[j], i + 1);
                        puntuations[i, j] = Convert.ToSingle(Console.ReadLine());
                    }
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine("Enter karakter {0} group {1}", class2[j], i + 1);
                        puntuations[i, j] = Convert.ToSingle(Console.ReadLine());
                    }
                }
                
            }
            for (int j = 0; j < 10; j++)
            {

                AVG += puntuations[0, j];
                AVGclass2 += puntuations[0, j];
            }
            Console.WriteLine("Gennemsnit for klasse 1: "+AVG/10);
            Console.WriteLine("Gennemsnit for klasse 2: " + AVGclass2 / 10);
        }
    }
}
