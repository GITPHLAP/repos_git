using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battleship
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Game newgame = new Game();
        public MainWindow()
        {
            //string test = "test_p1";
            //string[] testarray = test.Split('_');
            //Console.WriteLine(testarray[0]);

            InitializeComponent();


        }
        static string[] shipname;
        static Button selectedbuttonandship;
        static Grid selectedplayer;
        List<Button> selectedships = new List<Button>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button thisbutton = sender as Button;
            int col = Grid.GetColumn(thisbutton); //return x value
            int row = Grid.GetRow(thisbutton);  //return y value
            bool gridandshipEnable;

            if (newgame.Isgamebegun)
            {
                if (newgame.Checkfieldforships(col, row) == "aircraftCarrier" || newgame.Checkfieldforships(col, row) == "battleship" || newgame.Checkfieldforships(col, row) == "submarine" || newgame.Checkfieldforships(col, row) == "cruiser" || newgame.Checkfieldforships(col, row) == "destroyer")
                {
                    //thisbutton.IsEnabled = false;

                    thisbutton.Background = Brushes.Red;
                    newgame.AddHitShipToCounter(newgame.Checkfieldforships(col, row));
                    if (newgame.CheckIfOneShipIsSunk(newgame.Checkfieldforships(col, row)))
                    {
                        MessageBox.Show("Du har sunket din modstanders: " + newgame.Checkfieldforships(col, row), "Congratulation");
                    }
                    if (newgame.CheckIfAllShipIsSunk())
                    {
                        if (newgame.Whichturn % 2 == 0)
                        {
                            MessageBox.Show("Player1 har vundet", "Congratulation");
                        }
                        else
                        {
                            MessageBox.Show("Player1 har vundet", "Congratulation");
                        }
                    }
                    thisbutton.Name = newgame.Shoot("Hit");
                    if (newgame.Whichturn % 2 == 0)
                    {
                        player2Grid.IsEnabled = true;
                        player1Grid.IsEnabled = false;

                    }
                    else
                    {
                        player1Grid.IsEnabled = true;
                        player2Grid.IsEnabled = false;
                    }

                }
                else
                {
                    thisbutton.Name = newgame.Shoot("Miss");
                    thisbutton.Background = Brushes.Blue;
                    if (newgame.Whichturn % 2 == 0)
                    {
                        player2Grid.IsEnabled = true;
                        player1Grid.IsEnabled = false;
                    }
                    else
                    {
                        player1Grid.IsEnabled = true;
                        player2Grid.IsEnabled = false;
                    }
                }
            }
            else
            {
                switch (selectedplayer.Name)
                {

                    case "player1Grid":
                        Console.WriteLine("L: {0} x {1}", col, row);  //print x and y
                        newgame.SetShipPosition(col, row, shipname[0], "player1"); //set field value
                        gridandshipEnable = newgame.EnableShipAndGrid(shipname[0], "player1");
                        selectedplayer.IsEnabled = gridandshipEnable;
                        thisbutton.IsEnabled = false;
                        selectedships.Add(thisbutton);
                        selectedbuttonandship.IsEnabled = gridandshipEnable;
                        break;
                    case "player2Grid":
                        Console.WriteLine("L: {0} x {1}", col, row);  //print x and y
                        newgame.SetShipPosition(col, row, shipname[0], "player2"); //set field value
                        gridandshipEnable = newgame.EnableShipAndGrid(shipname[0], "player2");
                        selectedplayer.IsEnabled = gridandshipEnable;
                        thisbutton.IsEnabled = false;
                        selectedships.Add(thisbutton);
                        selectedbuttonandship.IsEnabled = gridandshipEnable;
                        break;
                    default:
                        break;
                }
            }




        }

        private void Selectship_Click(object sender, RoutedEventArgs e)
        {
            selectedplayer.IsEnabled = true;
            selectedbuttonandship = sender as Button;
            shipname = selectedbuttonandship.Name.Split('_');
            Console.WriteLine(shipname[0]);

        }

        private void Selectplayer_Click(object sender, RoutedEventArgs e)
        {
            Button selectedgrid = sender as Button;
            switch (selectedgrid.Name)
            {
                case "player1Grid1":
                    selectedplayer = player1Grid as Grid;
                    aircraftCarrier_P1.IsEnabled = newgame.EnableShipAndGrid("aircraftCarrier", "player1");
                    battleship_P1.IsEnabled = newgame.EnableShipAndGrid("battleship", "player1");
                    submarine_P1.IsEnabled = newgame.EnableShipAndGrid("submarine", "player1");
                    cruiser_P1.IsEnabled = newgame.EnableShipAndGrid("cruiser", "player1");
                    destroyer_P1.IsEnabled = newgame.EnableShipAndGrid("destroyer", "player1");
                    break;
                case "player2Grid1":
                    selectedplayer = player2Grid as Grid;
                    aircraftCarrier_P2.IsEnabled = newgame.EnableShipAndGrid("aircraftCarrier", "player2");
                    battleship_P2.IsEnabled = newgame.EnableShipAndGrid("battleship", "player2");
                    submarine_P2.IsEnabled = newgame.EnableShipAndGrid("submarine", "player2");
                    cruiser_P2.IsEnabled = newgame.EnableShipAndGrid("cruiser", "player2");
                    destroyer_P2.IsEnabled = newgame.EnableShipAndGrid("destroyer", "player2");
                    break;
                default:
                    break;
            }
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            newgame.Isgamebegun = true;
            player1Grid.IsEnabled = false;
            foreach (var item in selectedships)
            {
                item.IsEnabled = true;
            }
            aircraftCarrier_P1.IsEnabled = false;
            battleship_P1.IsEnabled = false;
            submarine_P1.IsEnabled = false;
            cruiser_P1.IsEnabled = false;
            destroyer_P1.IsEnabled = false;
            aircraftCarrier_P2.IsEnabled = false;
            battleship_P2.IsEnabled = false;
            submarine_P2.IsEnabled = false;
            cruiser_P2.IsEnabled = false;
            destroyer_P2.IsEnabled = false;
            player2Grid.IsEnabled = true;

        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Restart();
        }

        private void DirectionUp_Click(object sender, RoutedEventArgs e)
        {
            newgame.SetShipdirection("up");
        }

        private void DirectionLeft_Click(object sender, RoutedEventArgs e)
        {
            newgame.SetShipdirection("left");
        }

        private void DirectionRight_Click(object sender, RoutedEventArgs e)
        {
            newgame.SetShipdirection("right");
        }

        private void DirectionDown_Click(object sender, RoutedEventArgs e)
        {
            newgame.SetShipdirection("down");
        }
        public void CheckFields()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (newgame.player1.playerboard.fieldcontaine[i, j] != null)
                    {
                    }

                }
            }
        }
    }
}
