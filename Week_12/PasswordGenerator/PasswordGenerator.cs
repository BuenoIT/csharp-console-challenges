using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class PasswordGenerator
    {
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string AllCharacters = UppercaseLetters + LowercaseLetters + Digits;
        private readonly Random _random = new Random();

        public string GeneratePassword(int length)
        {
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = AllCharacters[_random.Next(AllCharacters.Length)];
            }

            return new string(password);
        }

        public bool IsPasswordValid(string generatedPassword, string userPassword)
        {
            return generatedPassword == userPassword;
        }
    }
}
