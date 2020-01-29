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
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Test_image_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MoviePanel: Window
    {
        public MoviePanel()
        {
            InitializeComponent();
        }
        List<ImageSource> movie_posters_list = new List<ImageSource>();
        List<String> movie_names = new List<String>();
        String regex_pattern = @"\\([\w ]+).(?:jpg|png)$";


        public void LoadImages()
        {
            //Image current_image;
            String movie_poster_path = @"C:\Users\Vax\Desktop\movie_posters";
            List<String> filenames = new List<String>(System.IO.Directory.EnumerateFiles(movie_poster_path, "*.jpg"));

            foreach (String filename in filenames)
            {
                this.movie_posters_list.Add(new BitmapImage(new Uri(filename)));
                Console.WriteLine("filename " + filename);
                Match regex_match = Regex.Match(filename.Trim(), regex_pattern);
                String matched_movie_name = regex_match.Groups[1].Value;
                this.movie_names.Add(matched_movie_name);
                Console.WriteLine("Movie Name: " + matched_movie_name);

            }

            MovieListView.ItemsSource = movie_posters_list;
        }

    }

}