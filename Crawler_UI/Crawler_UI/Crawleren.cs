using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Crawler_UI
{
    class Crawleren
    {
        public class AcessUrl
        {
            public static string url = "";
            
        }
        public static void Filter(TextBox Year, TextBox KM, TextBox Price, TextBox Fuel, TextBox HK, TextBox KML, TextBox URL)
        {
            string Year_string = Year.Text;
            string KM_string = KM.Text;
            string Price_string = Price.Text;
            string Fuel_string = Fuel.Text;
            string HK_string = HK.Text;
            string KML_string = KML.Text;

            AcessUrl.url = $"https://www.bilbasen.dk/brugt/bil?IncludeEngrosCVR=true&YearFrom={Year_string}&MileageTo={KM_string}&PriceFrom=0&PriceTo={Price_string}&includeLeasing=false&Fuel={Fuel_string}&HpFrom={HK_string}&Distance=100&ZipCode=4450&KmlFrom={KML_string}";
            URL.Text = AcessUrl.url;

            AcessResult.Resultatet.Clear();
        }
        public class AcessResult
        {
            public static List<string> Resultatet = new List<string>();
        }
       
        static string newLine = Environment.NewLine;
            
        public static async Task startCrawlerasync( TextBox result)
        {
            
            
            for (int i = 1; i < 4; i++)
            {
                int x = i ;
                var url = $"{AcessUrl.url}&page="+x; // gør det for at den finder det på hver side så .... page= x og x stiger med en for hvergang den er kørt en omgang
                var httpClient = new HttpClient();
                var html = await httpClient.GetStringAsync(url);

                byte[] bytes = Encoding.Default.GetBytes(html);
                
                var convertetwebsite = Encoding.UTF8.GetString(bytes);

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(convertetwebsite);
                Bil bil = new Bil();
                List<Bil> biler = new List<Bil>();
                var divs = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("row listing listing-plus bb-listing-clickable")).ToList();

                AcessResult.Resultatet.Add($"Side {i}");
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
                    var afgift_split = afgift.Split(new char[] {'&' });
                    afgift = afgift_split[0];

                    bil.Model = Model;
                    bil.KM = KM;
                    bil.Pris = Pris;
                    bil.år = ModelÅr;
                    bil.KML = KML;
                    bil.afgift = afgift;
                    bil.HK = HK;
                    biler.Add(bil);

                    AcessResult.Resultatet.Add($"{Model} fra {ModelÅr} Den koster {Pris} {newLine}Den har kørt {KM} den køre {KML} afgiften på den er {afgift}år og den har en motor på {HK}");
                    
                }

                var divsA = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("row listing listing-discount bb-listing-clickable")).ToList();
                foreach (var div in divsA)
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
                    biler.Add(bil);

                    AcessResult.Resultatet.Add($"{Model} fra {ModelÅr} Den koster {Pris} {newLine}Den har kørt {KM} den køre {KML} afgiften på den er {afgift}år og den har en motor på {HK}");

                }
                
                result.Clear();
                foreach (var item in AcessResult.Resultatet)
                {

                    result.Text += item + "\n\n";

                }
            }

            
        }

    }
}