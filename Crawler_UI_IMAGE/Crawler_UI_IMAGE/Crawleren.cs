using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Crawler_UI_IMAGE
{
    class Crawleren
    {
       public static int number = 0;
        public class AcessUrl
        {
            public static string url1 = "";

        }
        public static void Filter(TextBox Year, TextBox KM, TextBox Price, TextBox Fuel, TextBox HK, TextBox KML, TextBox URL)
        {
            string Year_string = Year.Text;
            string KM_string = KM.Text;
            string Price_string = Price.Text;
            string Fuel_string = Fuel.Text;
            string HK_string = HK.Text;
            string KML_string = KML.Text;

            AcessUrl.url1 = $"https://www.bilbasen.dk/brugt/bil?IncludeEngrosCVR=true&YearFrom={Year_string}&MileageTo={KM_string}&PriceFrom=0&PriceTo={Price_string}&includeLeasing=false&Fuel={Fuel_string}&HpFrom={HK_string}&Distance=100&ZipCode=4450&KmlFrom={KML_string}";
            URL.Text = AcessUrl.url1;

            AcessResult.Resultatet.Clear();
        }
        public class AcessResult
        {
            public static List<string> Resultatet = new List<string>();
        }

        public class AcessImageURL
        {
            public static List<string> ImageURL = new List<string>();
        }

        static string newLine = Environment.NewLine;

        public static async Task startCrawlerasync(TextBox result, RichTextBox result2)
        {


            for (int i = 1; i < 3; i++)
            {
                int x = i;
                var url = $"{AcessUrl.url1}&page=" + x; // gør det for at den finder det på hver side så .... page= x og x stiger med en for hvergang den er kørt en omgang
                var httpClient = new HttpClient();
                var html = await httpClient.GetStringAsync(url);

                byte[] bytes = Encoding.Default.GetBytes(html);

                var convertetwebsite = Encoding.UTF8.GetString(bytes);

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(convertetwebsite);
                Bil bil = new Bil();
                List<Bil> biler = new List<Bil>();
                var divs = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("row listing listing-plus bb-listing-clickable")).ToList();

                Paragraph block = new Paragraph(); ;
                //block.Inlines.Add($"Side: {x} ");
                //result2.Document.Blocks.Add(block);
                result.Text += $"Side: {x} \n\n";
                //AcessResult.Resultatet.Add($"Side {i}");
                foreach (var div in divs)
                {
                    //bruges til at udvælge antal kilometer kørt istedet for alt det andet der er i den Class 
                    var @test = div.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("col-xs-2 listing-data ")).ToList();
                    var kmtest = test[1].InnerHtml;


                    var Model = div.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("listing-heading darkLink")).FirstOrDefault().InnerText;
                    var Link = div.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("listing-heading darkLink")).FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value;
                    var Img_Link = div.Descendants("img").Where(node => node.GetAttributeValue("class", "").Equals("img-thumbnail listing-thumbs-lg")).FirstOrDefault().ChildAttributes("data-echo").FirstOrDefault().Value;
                    var Pris = div.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("col-xs-3 listing-price ")).FirstOrDefault().InnerText;
                    var KM = kmtest; // her kalder jeg den
                    var @class = div.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("col-xs-2 listing-data ")).ToList();
                    var ModelÅr = @class[2].InnerHtml;
                    var KML = div.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("variableDataColumn")).FirstOrDefault().ChildAttributes("data-kml").FirstOrDefault().Value;
                    var HK = div.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("variableDataColumn")).FirstOrDefault().ChildAttributes("data-hk").FirstOrDefault().Value;
                    var afgift = div.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("variableDataColumn")).FirstOrDefault().ChildAttributes("data-moth").FirstOrDefault().Value;
                    var afgift_split = afgift.Split(new char[] { '&' });
                    afgift = afgift_split[0];

                    bil.Model = Model;
                    bil.KM = KM;
                    bil.Pris = Pris;
                    bil.år = ModelÅr;
                    bil.KML = KML;
                    bil.afgift = afgift;
                    bil.HK = HK;
                    bil.Img_Link = Img_Link;
                    biler.Add(bil);


                    AcessImageURL.ImageURL.Add(Img_Link);
                    AcessResult.Resultatet.Add($"{Img_Link}£{Model} fra {ModelÅr} Den koster {Pris} {newLine}Den har kørt {KM} den køre {KML} afgiften på den er {afgift}år og den har en motor på {HK}");

                }

                var divsA = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("row listing listing-discount bb-listing-clickable")).ToList();
                foreach (var divA in divsA)
                {
                    //bruges til at udvælge antal kilometer kørt istedet for alt det andet der er i den Class 
                    var @test = divA.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("col-xs-2 listing-data ")).ToList();
                    var kmtest = test[1].InnerHtml;


                    var Model = divA.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("listing-heading darkLink")).FirstOrDefault().InnerText;
                    var Link = divA.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("listing-heading darkLink")).FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value;
                    var Img_Link = divA.Descendants("img").Where(node => node.GetAttributeValue("class", "").Equals("img-thumbnail listing-thumbs-lg")).FirstOrDefault().ChildAttributes("data-echo").FirstOrDefault().Value;
                    var Pris = divA.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("col-xs-3 listing-price ")).FirstOrDefault().InnerText;
                    var KM = kmtest; // her kalder jeg den
                    var @class = divA.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("col-xs-2 listing-data ")).ToList();
                    var ModelÅr = @class[2].InnerHtml;
                    var KML = divA.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("variableDataColumn")).FirstOrDefault().ChildAttributes("data-kml").FirstOrDefault().Value;
                    var HK = divA.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("variableDataColumn")).FirstOrDefault().ChildAttributes("data-hk").FirstOrDefault().Value;
                    var afgift = divA.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("variableDataColumn")).FirstOrDefault().ChildAttributes("data-moth").FirstOrDefault().Value;
                    var afgift_split = afgift.Split(new char[] { '&' });
                    afgift = afgift_split[0];

                    bil.Model = Model;
                    bil.KM = KM;
                    bil.Pris = Pris;
                    bil.år = ModelÅr;
                    bil.KML = KML;
                    bil.afgift = afgift;
                    bil.HK = HK;
                    bil.Img_Link = Img_Link;
                    biler.Add(bil);


                    AcessImageURL.ImageURL.Add(Img_Link);
                    AcessResult.Resultatet.Add($"{Img_Link}£{Model} fra {ModelÅr} Den koster {Pris} {newLine}Den har kørt {KM} den køre {KML} afgiften på den er {afgift}år og den har en motor på {HK}");

                }
                result2.Document.Blocks.Clear();
                //result.Clear();
                foreach (var item in AcessResult.Resultatet)
                {
                    var item_split = item.Split(new char[] { '£' });
                    var item_print_img_link = item_split[0];
                    var item_print_text = item_split[1];

                    //Paragraph block = new Paragraph();
                    BitmapImage bitmapSmiley = new BitmapImage(new Uri(item_print_img_link /*, UriKind.Relative*/));
                    Image smiley = new Image();
                    smiley.Source = bitmapSmiley;
                    smiley.Width = 50;
                    smiley.Height = 50;
                    block.Inlines.Add(smiley);

                    

                    
                    block.Inlines.Add(item_print_text);
                    result2.Document.Blocks.Add(block);
                    number++;
                    result.Text += item_print_text + "\n\n";
                }
                //1 måde
                //Tuple<List<string>, List<string>> print = new Tuple<List<string>, List<string>>(AcessImageURL.ImageURL, AcessResult.Resultatet);

                //foreach (var item in print.Item2)
                //{
                //Paragraph block = new Paragraph();
                //BitmapImage bitmapSmiley = new BitmapImage(new Uri(item /*, UriKind.Relative*/));
                //Image smiley = new Image();
                //smiley.Source = bitmapSmiley;
                //smiley.Width = 50;
                //smiley.Height = 50;
                //block.Inlines.Add(smiley);

                //result.Text += AcessResult.Resultatet[number] + "\n\n";

                //result.Text += item + "\n\n";
                //block.Inlines.Add(print.Item2[number]);
                //result2.Document.Blocks.Add(block);
                //number++;
                //result.Text += AcessResult.Resultatet[j] + "\n\n";
                //}
                //1 måde slut
            }
            //2 måde
            //for (int j = 0; j < AcessImageURL.ImageURL.Count-1; j++)
            //    {
                
            //    Paragraph block = new Paragraph();
            //        BitmapImage bitmapSmiley = new BitmapImage(new Uri(AcessImageURL.ImageURL[j] /*, UriKind.Relative*/));
            //        Image smiley = new Image();
            //        smiley.Source = bitmapSmiley;
            //        smiley.Width = 500;
            //        smiley.Height = 500;
            //        block.Inlines.Add(smiley);
                    

            //        block.Inlines.Add(AcessResult.Resultatet[j]);
            //        result2.Document.Blocks.Add(block);
            //        //result.Text += AcessResult.Resultatet[j] + "\n\n";
            //    }
            //2 måde slut

        }
    }
}
