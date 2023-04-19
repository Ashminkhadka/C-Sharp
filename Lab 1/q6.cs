using System;

interface IShape {
    double CalculateArea();
}

interface IRectangle {
    double Width { get; set; }
    double Height { get; set; }
}

class Rectangle : IShape, IRectangle {
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea() {
        return Width * Height;
    }
}

class Program {
    static void Main(string[] args) {
        Rectangle rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine("Area of rectangle: {0}", rect.CalculateArea());
    }
}