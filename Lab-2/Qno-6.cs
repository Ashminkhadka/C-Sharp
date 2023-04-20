using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>() { "Ram", "Shyam", "Hari", "Bikash", "Mahesh" };

        var sortedNames = from name in names
                          orderby name
                          select name;

        Console.WriteLine("Sorted Names:");

        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();
    }
}