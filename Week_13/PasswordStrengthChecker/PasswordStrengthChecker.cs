using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrengthChecker
{
    internal class PasswordStrengthChecker
    {
        private string password;

        public PasswordStrengthChecker(string password)
        {
            this.password = password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return password;
        }

        public bool CheckLength()
        {
            return password.Length >= 8;
        }

        public bool CheckUppercase()
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckLowercase()
        {
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDigits()
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckSpecialChars()
        {
            string specialChars = "!@#$%^&*(),.?\"':{}|<>";
            foreach (char c in password)
            {
                if (specialChars.Contains(c.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsStrongPassword()
        {
            return CheckLength() && CheckUppercase() && CheckLowercase() && CheckDigits() && CheckSpecialChars();
        }

        public static string GenerateRandomPassword(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*(),.?\"':{}|<>";
            Random random = new Random();
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }
    }
}
