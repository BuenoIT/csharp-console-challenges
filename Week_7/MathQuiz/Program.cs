using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            for (int i = 1; i <= 10; i++)
            {
                // Generate a random math question
                int a = GenerateRandomNumber(1, 10);
                int b = GenerateRandomNumber(1, 10);
                int result = 0;
                char op = GetRandomOperator();

                switch (op)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        result = a / b;
                        break;
                }

                // Ask the user for the answer
                Console.Write($"{i}. What is {a} {op} {b}? ");
                int answer = Convert.ToInt32(Console.ReadLine());

                // Check the answer
                if (answer == result)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {result}.");
                }

                Console.WriteLine();
            }

            // Display the final score
            Console.WriteLine($"You scored {score} out of 10.");
            Console.ReadKey();
        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        static char GetRandomOperator()
        {
            char[] operators = { '+', '-', '*', '/' };
            Random random = new Random();
            return operators[random.Next(operators.Length)];
        }
    }
}
