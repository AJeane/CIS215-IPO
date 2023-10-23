using System;
using System.Linq;

namespace TextMetricsAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            // Calculate metrics
            int wordCount = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = input.Length;
            int specialCharCount = input.Count(char.IsPunctuation);
            int numCount = input.Count(char.IsDigit);

            // Output the results
            Console.WriteLine($"Word Count: {wordCount}");
            Console.WriteLine($"Character Count: {charCount}");
            Console.WriteLine($"Special Character Count: {specialCharCount}");
            Console.WriteLine($"Number Count: {numCount}");
        }
    }
}