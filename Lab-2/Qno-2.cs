using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {

        return (double)a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int a = 24;
        int b = 6;

        Console.WriteLine("a = " + a + ", b = " + b);

        int sum = calculator.Add(a, b);
        Console.WriteLine("Sum: " + sum);

        int difference = calculator.Subtract(a, b);
        Console.WriteLine("Subtract: " + difference);

        int product = calculator.Multiply(a, b);
        Console.WriteLine("Multiply: " + product);

        double quotient = calculator.Divide(a, b);
        Console.WriteLine("Divide: " + quotient);

        Console.ReadLine();
    }
}