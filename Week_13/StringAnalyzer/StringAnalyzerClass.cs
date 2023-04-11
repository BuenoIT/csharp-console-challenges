using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyzer
{
    internal class StringAnalyzerClass
    {
        public int CountOccurrences(string text, string substring)
        {
            int count = 0;
            int index = 0;
            while (index < text.Length)
            {
                if (text.Substring(index).StartsWith(substring))
                {
                    index += substring.Length;
                    count++;
                }
                else
                {
                    index++;
                }
            }
            return count;
        }
    }
}
