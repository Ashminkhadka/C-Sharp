using System;
using System.Linq;

namespace ArraySquareExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers separated by spaces:");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            var result = from num in numbers
                         select new { Number = num, Square = num * num };


            foreach (var data in result)
            {
                Console.WriteLine($"The square of {data.Number} is {data.Square}");
            }

            Console.ReadLine();
        }
    }
}