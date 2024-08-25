using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts user for length of rectangle
            Console.WriteLine("Enter the length of the rectangle:");
            //Stores user's input for length of rectangle
            int length = Convert.ToInt32(Console.ReadLine());
            //Prompts for user for width of rectangle
            Console.WriteLine("Enter the width of the rectangle:");
            //Stores user's input for width of rectangle
            int width = Convert.ToInt32(Console.ReadLine());
            //Prints out area of rectangle
            Console.WriteLine("Area of the Rectangle: " + length * width);
            //Prints out perimeter of rectangle
            Console.WriteLine("Perimeter of the Rectangle: " + (length + width) * 2);
            //Read line of input from user
            Console.Read();
        }
    }
}
