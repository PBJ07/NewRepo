using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C__Review_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*Average*/
            //Pearl Baburaj
            //February 8 2024
            /*Keep getting values between 1-100 from user
             *calculate and output an average from the values inputted*/
            double num;
            double average = 0;
            double divident = 0;
            double total;
            
            Console.WriteLine("AVERAGE CALCULATOR\nType in numbers between 1 & 100 to calculate the average of them.\n ");
            Console.Write("Type a number: ");
            num = double.Parse(Console.ReadLine());
            //Keep getting values until you type -1
            while (num != -1) 
            {
                //If the number is in range, adding average and divident
                if (num >= 1 && num <= 100)
                {
                    average = average + num;
                    divident++;
                    Console.Write("Type a number: ");
                    num = double.Parse(Console.ReadLine());
                }
                else if (num > 100 || num < 1) 
                {
                    Console.WriteLine("Please enter a number within 1-100.");
                    Console.Write("Type a number: ");
                    num = double.Parse(Console.ReadLine());
                }
            }
            //Calculate and output average
            total = average / divident; 
            Console.WriteLine($"You have exited the program.\nThe average of your numbers is {total.ToString("N2")}.");
            Console.WriteLine("Thank you for using the Average Calculator!");

        }
    }
}
