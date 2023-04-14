using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrengthChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Generate a random password of length 10
            string randomPassword = PasswordStrengthChecker.GenerateRandomPassword(10);

            Console.WriteLine("Generated Random Password: " + randomPassword);

            // Create an instance of PasswordStrengthChecker
            PasswordStrengthChecker passwordChecker = new PasswordStrengthChecker(randomPassword);

            // Check password strength
            Console.WriteLine("Password Length: " + passwordChecker.CheckLength());
            Console.WriteLine("Contains Uppercase: " + passwordChecker.CheckUppercase());
            Console.WriteLine("Contains Lowercase: " + passwordChecker.CheckLowercase());
            Console.WriteLine("Contains Digits: " + passwordChecker.CheckDigits());
            Console.WriteLine("Contains Special Characters: " + passwordChecker.CheckSpecialChars());
            Console.WriteLine("Is Strong Password: " + passwordChecker.IsStrongPassword());

            // Set a new password
            passwordChecker.SetPassword("MyNewPassword123!");

            Console.WriteLine("");

            Console.WriteLine("Password: MyNewPassword123!");

            // Check password strength again
            Console.WriteLine("Password Length: " + passwordChecker.CheckLength());
            Console.WriteLine("Contains Uppercase: " + passwordChecker.CheckUppercase());
            Console.WriteLine("Contains Lowercase: " + passwordChecker.CheckLowercase());
            Console.WriteLine("Contains Digits: " + passwordChecker.CheckDigits());
            Console.WriteLine("Contains Special Characters: " + passwordChecker.CheckSpecialChars());
            Console.WriteLine("Is Strong Password: " + passwordChecker.IsStrongPassword());

            Console.ReadKey();
        }
    }
}
