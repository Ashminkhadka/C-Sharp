using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> customers = new Dictionary<int, string>();

        customers.Add(101, "Ashmin");
        customers.Add(102, "Harley");
        customers.Add(103, "David");

        foreach (KeyValuePair<int, string> customer in customers)
        {
            Console.WriteLine("Customer ID: " + customer.Key + ", Name: " + customer.Value);
        }

        Console.ReadLine();
    }
}