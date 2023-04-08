using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input the length and width of the rectangle
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the rectangle
            double area = length * width;

            // Output the area of the rectangle
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadKey();
        }
    }
}
