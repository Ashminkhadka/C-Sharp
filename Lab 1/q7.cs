using System;

class Shape {
    public virtual void Draw() {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape {
    public override void Draw() {
        Console.WriteLine("Drawing a circle.");
    }
}

class Square : Shape {
    public override void Draw() {
        Console.WriteLine("Drawing a square.");
    }
}

class Program {
    static void Main(string[] args) {
        Shape[] shapes = new Shape[] {
            new Shape(),
            new Circle(),
            new Square()
        };

        foreach (Shape shape in shapes) {
            shape.Draw();
        }
    }
}