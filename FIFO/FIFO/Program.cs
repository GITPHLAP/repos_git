using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(@" 
    ________                       __         .__  .__         __             __  .__.__    
   /  _____/_____    ____   ______/  |_  ____ |  | |__| ______/  |_  ____   _/  |_|__|  |   
  /   \  ___\__  \ _/ __ \ /  ___\   ___/ __ \|  | |  |/  ___\   ___/ __ \  \   __|  |  |   
  \    \_\  \/ __ \\  ___/ \___ \ |  | \  ___/|  |_|  |\___ \ |  | \  ___/   |  | |  |  |__ 
   \______  (____  /\___  /____  >|__|  \___  |____|__/____  >|__|  \___  >  |__| |__|____/ 
          \/     \/     \/     \/           \/             \/           \/                  
");
            Console.WriteLine(@"
   ____  __.           ______________   ____      ____   ___._____________  __________               __          
  |    |/ ______ ___  _\__    ___\   \ /   ______ \   \ /   |   \______   \ \______   _____ ________/  |_ ___.__.
  |      < \__  \\  \/ / |    |   \   Y   /  ___/  \   Y   /|   ||     ___/  |     ___\__  \\_  __ \   __<   |  |
  |    |  \ / __ \\   /  |    |    \     /\___ \    \     / |   ||    |      |    |    / __ \|  | \/|  |  \___  |
  |____|__ (____  /\_/   |____|     \___//____  >    \___/  |___||____|      |____|   (____  |__|   |__|  / ____|
          \/    \/                            \/                                           \/             \/     
");


            Console.WriteLine("Gæsteliste til KavTVs VIP Party");
            GUI start = new GUI();//starter klassen GUI

            while (true)//executer min metode intil programmet bliver lukket
            {
                start.menu();//executer min metode

                Console.ReadLine(); //venter på et enter
            }
        }
    }
}
