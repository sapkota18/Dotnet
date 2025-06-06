using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overload the + operator
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(2, 3);
        Point p2 = new Point(4, 5);

        Point result = p1 + p2; // Using overloaded + operator

        Console.WriteLine("Result of adding two points:");
        result.Display();
    }
}
