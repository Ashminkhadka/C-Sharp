using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
}