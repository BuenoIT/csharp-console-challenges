using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            int count1 = CountVowels(str1);
            Console.WriteLine($"The number of vowels in '{str1}' is: {count1}");

            string str2 = "This is a test";
            int count2 = CountVowels(str2);
            Console.WriteLine($"The number of vowels in '{str2}' is: {count2}");

            string str3 = "AEIOU";
            int count3 = CountVowels(str3);
            Console.WriteLine($"The number of vowels in '{str3}' is: {count3}");

            Console.ReadKey();
        }

        public static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsVowel(char c)
        {
            switch (Char.ToLower(c))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}
