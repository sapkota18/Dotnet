using System;

abstract class Shape
{
    public abstract void Draw(); // abstract method

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Program
{
    static void Main()
    {
        Shape shape = new Circle(); // Polymorphism
        shape.Display();
        shape.Draw();
    }
}
