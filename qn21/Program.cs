using System;

interface IShape
{
    void Draw();  // Interface method (no body)
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

class Program
{
    static void Main()
    {
        IShape shape1 = new Circle();
        shape1.Draw();

        IShape shape2 = new Rectangle();
        shape2.Draw();
    }
}
