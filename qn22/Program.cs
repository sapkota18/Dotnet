using System;

// Define a delegate that takes a string parameter and returns void
delegate void SimpleDelegate(string message);

class Program
{
    static void ShowMessage(string msg)
    {
        Console.WriteLine("ShowMessage: " + msg);
    }

    static void Main()
    {
        // Create a delegate instance pointing to ShowMessage method
        SimpleDelegate del = ShowMessage;

        // Invoke the delegate
        del("Hello from single delegate!");
    }
}
