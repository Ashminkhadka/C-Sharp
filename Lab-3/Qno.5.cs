using System;
using System.Collections.Generic;
using System.Linq;

namespace StartEndExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>
            {
                "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                "NEWDELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
            };

            Console.WriteLine("Enter the starting character:");
            char startChar = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEnter the ending character:");
            char endChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            var result = from city in cities
                         where city.StartsWith(startChar.ToString(), StringComparison.OrdinalIgnoreCase)
                               && city.EndsWith(endChar.ToString(), StringComparison.OrdinalIgnoreCase)
                         select city;

            Console.WriteLine($"\nCities starting with '{startChar}' and ending with '{endChar}':");
            foreach (string city in result)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}