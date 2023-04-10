using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            Console.Write("Please enter the length of the password: ");
            int passwordLength = int.Parse(Console.ReadLine());

            string generatedPassword = passwordGenerator.GeneratePassword(passwordLength);
            Console.WriteLine("Generated password: {0}\n", generatedPassword);

            bool isPasswordValid = false;
            do
            {
                Console.Write("Please enter the password: ");
                string userPassword = Console.ReadLine();

                isPasswordValid = passwordGenerator.IsPasswordValid(generatedPassword, userPassword);
                if (isPasswordValid)
                {
                    Console.WriteLine("Success! You entered the correct password.\n");
                }
                else
                {
                    Console.WriteLine("Failure! You entered an incorrect password.\n");
                }
            } while (!isPasswordValid);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
