using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Crawler_UI_IMAGE
{
    class Filter_url
    {
        public class AcessUrl
        {
            public static string url = "";
        }
        public static void Filter(TextBox Year, TextBox KM, TextBox Price, TextBox Fuel, TextBox HK, TextBox KML, TextBox URL, TextBox result)
        {
            string Year_string = Year.Text;
            string KM_string = KM.Text;
            string Price_string = Price.Text;
            string Fuel_string = Fuel.Text;
            string HK_string = HK.Text;
            string KML_string = KML.Text;

            AcessUrl.url = $"https://www.bilbasen.dk/brugt/bil?IncludeEngrosCVR=true&YearFrom={Year_string}&MileageTo={KM_string}&PriceFrom=0&PriceTo={Price_string}&includeLeasing=false&Fuel={Fuel_string}&HpFrom={HK_string}&Distance=100&ZipCode=4450&KmlFrom={KML_string}";

        }
        //ÅR        YearFrom=****
        //max kørte Km  MileageTo=*****
        //pris      PriceFrom=0&PriceTo=*****
        //leasing includeLeasing=false
        //brændstof Fuel=* //1 er benzin... 2 er Diesel... 3 er EL
        //HK        HpFrom=**
        //Distance=100&ZipCode=4450
        // KML      KmlFrom=**
    }
}

