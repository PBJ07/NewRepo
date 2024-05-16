using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C__Review_1
{
    //Pearl Baburaj
    //February 6 2024
    //Hotdog Vendor. Calcualte price of hotdogs and ask for donation
    internal class Program
    {
        static void Main(string[] args)
        {

            double hotdogs = 4.50;
            double tax = 0.13;  //provincial tax for ON
            int cost;
            double donate;
            double total;
            double cost2;

    
            Console.Write("Hello! Welcome to the food truck. \nHow many hotdogs would you like? ");
            //Calculate price of hotdogs plus donation
            cost = int.Parse(Console.ReadLine());
            cost2 = (cost * hotdogs);
            Console.Write("How much would you like to donate to 'Hotdogs for the Hungry Fund'? $");
            donate = double.Parse(Console.ReadLine());
            total = (donate + (cost2 + (cost2*tax))); 
            Console.WriteLine($"Perfect! Your total comes out to be: {total.ToString("C2")}");
        }
    }
}
