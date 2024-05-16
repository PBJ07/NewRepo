using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    //Pearl Baburaj
    //March 26 2024
    /*Ask user for number of tickets and gives a prize based on that*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int tickets;
            Console.WriteLine("ARCADE PRIZE BOOTH\nHi, I see you would like to trade your tickets for some prizes!\n");
            do
            {
                Console.Write("\n(To exit the program enter -1)\nHow many tickets have you won? ");
                if (int.TryParse(Console.ReadLine(), out tickets))
                {
                    switch (tickets)
                    {
                        case int t when t >= 0 && t < 10:
                            Console.WriteLine("You do not have enough tickets. Play more games to win tickets!");
                            break;

                        case int t when t >= 10 && t <= 49:
                            Console.WriteLine("You win a plushie!");
                            break;

                        case int t when t >= 50 && t <= 99:
                            Console.WriteLine("You win a nerf gun!");
                            break;

                        case int t when t >= 100 && t <= 999:
                            Console.WriteLine("You win a skateboard!");
                            break;

                        case int t when t >= 1000:
                            Console.WriteLine("You win a Bluetooth Speaker!");
                            break;

                        case int t when t == -1:
                            Console.WriteLine("Thank you for coming to the arcade. Come again!");
                            break;

                        default:
                            Console.WriteLine("This is not a valid number of tickets.");
                            break;
                    }
                }
                else
                {
                    Console.Write("Please enter a number of tickets.");
                }
            }while (tickets != -1);
            Console.ReadKey();
        }
    }
}