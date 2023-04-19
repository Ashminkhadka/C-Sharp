using System;

// Single Inheritance
class Animal {
    public void Eat() {
        Console.WriteLine("The animal is eating.");
    }
}

class Dog : Animal {
    public void Bark() {
        Console.WriteLine("The dog is barking.");
    }
}

// Multiple Inheritance
interface IWalk {
    void Walk();
}

interface ISwim {
    void Swim();
}

class Duck : IWalk, ISwim {
    public void Walk() {
        Console.WriteLine("The duck is walking.");
    }

    public void Swim() {
        Console.WriteLine("The duck is swimming.");
    }
}

// Multilevel Inheritance
class Vehicle {
    public void Drive() {
        Console.WriteLine("The vehicle is being driven.");
    }
}

class Car : Vehicle {
    public void Honk() {
        Console.WriteLine("The car is honking its horn.");
    }
}

class SportsCar : Car {
    public void Accelerate() {
        Console.WriteLine("The sports car is accelerating.");
    }
}

// Hierarchical Inheritance
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
        // Single Inheritance
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
        Console.WriteLine();

        // Multiple Inheritance
        Duck duck = new Duck();
        duck.Walk();
        duck.Swim();
        Console.WriteLine();

        // Multilevel Inheritance
        SportsCar sportsCar = new SportsCar();
        sportsCar.Drive();
        sportsCar.Honk();
        sportsCar.Accelerate();
        Console.WriteLine();

        // Hierarchical Inheritance
        Shape[] shapes = new Shape[] { new Shape(), new Circle(), new Square() };
        foreach (Shape shape in shapes) {
            shape.Draw();
        }
    }
}