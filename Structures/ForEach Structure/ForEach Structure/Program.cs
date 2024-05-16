using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_Structure
{
    internal class Program
    {
        //Pearl Baburaj
        //March 4 2024
        /*for loop to fill the array with 10 random numbers between 1 and 10, displays the values. 
         *foreach loop displays and adds up only numbers in the array that are even
         *displays  sum of the even numbers.*/
        static void Main(string[] args)
        {
            int[] num = new int[10]; //array with 10 values

            Random rnd = new Random(); //random number variable
            Console.WriteLine("Your numbers are: ");
            //create and display 10 random numbers and put in num array 
            for (int i = 0; i < 10; i++) //create 10 random numbers and store in num array
            {
                num[i] = rnd.Next(1, 10);
                Console.WriteLine($"{num[i]}");
            }
            Console.WriteLine($"The even numbers are: ");
            int sum = 0;
            //check if numbers in array are even and display
            foreach (int nums in num) //run through numbers in array
            {
                //modulas operation to check if numbers in array are even
                if (nums%2 == 0)
                {
                    Console.WriteLine(nums); //display even numbers
                    sum += nums; //store and add even numbers 
                }
            }
            Console.WriteLine($"\nThe sum of the even numbers is {sum}");
        }
    }
}
