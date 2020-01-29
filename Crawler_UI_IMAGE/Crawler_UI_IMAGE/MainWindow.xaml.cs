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

namespace Crawler_UI_IMAGE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Crawleren.startCrawlerasync(result,result2);
            
            //byte[] bytes = Encoding.UTF8.GetBytes(result.Text);
            //Encoding enc = Encoding.GetEncoding("Windows-1252");
            //result.Text = enc.GetString(bytes);
        }

        private void Madeurl_Click(object sender, RoutedEventArgs e)
        {
            Crawleren.Filter(Filter_year,Filter_km, Filter_price, Filter_fuel, Filter_HK, Filter_kml, URl);

        }

        private void Reset_button_Click(object sender, RoutedEventArgs e)
        {
            result2.Document.Blocks.Clear();
            result.Clear();
            
        }

        private void Result2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
