using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycheck
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pearl Baburaj
            //February 22 2024
            /*Program calculates your paycheque based on your hourly wage and how much you worked*/
            double wage;
            double hours;
            double paychq;
            Console.WriteLine("Calculate your Paycheque!\nPlease input the valid information to calculate your paycheque or you cannot move onto the next question.\n");
            Console.Write("What is your hourly wage? $");
            //while loop if wage input is not valid
            while(double.TryParse(Console.ReadLine(), out wage) != true) //if input is not valid question repeats
            {
                Console.Write("What is your hourly wage? $");
            }
            Console.Write("How many hours have you worked? ");
            //while loop if hours input is not valid
            while (double.TryParse(Console.ReadLine(), out hours) != true) //if input is not valid question repeats
            {
                Console.Write("How many hours have you worked? ");
            }
            paychq = CalculatePay(wage, hours);
            Console.WriteLine($"Your paycheck is {paychq.ToString("C2")}");
        }

        //function to calculate pay
        static double CalculatePay(double wage, double hours) 
        {
            double pay = (wage * hours);
            return (pay);
        }
    }
}

