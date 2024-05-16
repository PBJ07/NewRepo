using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pearl Baburaj
            //February 24 2024
            /*Asks user for a number to multiply values in the array with
             Program multiplies and shows sum of multiplied numbers*/
            int[] nums = new int[] { 1, 2, 4, 8, 16 };
            int multiply;

            Console.WriteLine("Hello! I have the numbers 1,2,4,8 and 16 in my array and I need some help. ");
            Console.Write("What number should I multiply them with? ");
            //If user input is not valid, ask for them to input the valid number until they input valid number
            while (int.TryParse(Console.ReadLine(), out multiply) != true)
            {
                Console.WriteLine("\nPlease enter a valid number.");
                Console.Write("What number should I multiply by? ");
            }
            Console.Write("\nYour numbers are: ");
            //go through each value in the array and multiply them by user input number
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * multiply;
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine($"\nThe sum of these numbers is {nums.Sum()}");
            Console.WriteLine("Thank you for helping!");
            Console.ReadKey();
        }
    }
}
