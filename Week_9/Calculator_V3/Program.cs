using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = Add(num1, num2);
                        break;
                    case '-':
                        result = Subtract(num1, num2);
                        break;
                    case '*':
                        result = Multiply(num1, num2);
                        break;
                    case '/':
                        result = Divide(num1, num2);
                        break;
                    default:
                        throw new ArgumentException("Invalid operator entered.");
                }

                Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: Number is too large or too small to be represented as a double.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: An unexpected error occurred. Please try again.");
            }

            Console.ReadKey();
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            else
            {
                return num1 / num2;
            }
        }

    }
}
