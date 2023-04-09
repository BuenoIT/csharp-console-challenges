using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the temperature scale (C/F): ");
            char scale = Convert.ToChar(Console.ReadLine().ToUpper());

            double convertedTemp = 0;

            if (scale == 'C')
            {
                convertedTemp = (temp * 9 / 5) + 32;
                Console.WriteLine("{0} degrees Celsius is {1} degrees Fahrenheit.", temp, convertedTemp);
            }
            else if (scale == 'F')
            {
                convertedTemp = (temp - 32) * 5 / 9;
                Console.WriteLine("{0} degrees Fahrenheit is {1} degrees Celsius.", temp, convertedTemp);
            }
            else
            {
                Console.WriteLine("Error: Invalid scale entered.");
                return;
            }

            Console.ReadKey();
        }
    }
}
