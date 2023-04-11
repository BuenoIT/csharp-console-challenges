using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> texts = new List<string>() { "The code is code another code", "The coder is experienced", "I am a coder too", "Coding is fun" };
            StringAnalyzerClass analyzer = new StringAnalyzerClass();

            foreach (string text in texts)
            {
                int count = analyzer.CountOccurrences(text, "code");
                Console.WriteLine("\"" + text + "\" contains " + count + " occurrence(s) of \"code\".");
            }
            Console.ReadKey();
        }
    }
}
