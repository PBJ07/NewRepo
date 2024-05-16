using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number:  ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter another number:  ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            //this block runs if there is an error
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
