using System;

class Box<T>
{
    public T Value;

    public void Show()
    {
        Console.WriteLine("Value: " + Value);
    }

    public void PrintType<U>(U data)
    {
        Console.WriteLine("Data: " + data + ", Type: " + data.GetType());
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();
        intBox.Value = 10;
        intBox.Show();
        intBox.PrintType<string>("Hello");

        Box<string> strBox = new Box<string>();
        strBox.Value = "World";
        strBox.Show();
        strBox.PrintType<double>(3.14);
    }
}
