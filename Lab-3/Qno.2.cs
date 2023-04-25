using System;
using System.Linq;

namespace UpperCaseLettersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Original String :" + inputString);
            var upperCaseLetters = FindUpperCaseLetters(inputString);
            Console.WriteLine("Uppercase letters in the string:");
            foreach (var letter in upperCaseLetters)
            {
                Console.WriteLine(letter);
            }

        }

        static string FindUpperCaseLetters(string inputString)
        {
            var upperCaseLetters = from c in inputString
                                   where char.IsUpper(c)
                                   select c;
            return new string(upperCaseLetters.ToArray());
        }
    }
}