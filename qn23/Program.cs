using System;

delegate void MultiDelegate(string message);

class Program
{
    static void MethodOne(string msg)
    {
        Console.WriteLine("MethodOne: " + msg);
    }

    static void MethodTwo(string msg)
    {
        Console.WriteLine("MethodTwo: " + msg);
    }

    static void Main()
    {
        // Create delegate instance pointing to MethodOne
        MultiDelegate multiDel = MethodOne;

        // Add another method to invocation list
        multiDel += MethodTwo;

        // Invoke all methods subscribed to delegate
        multiDel("Hello from multicast delegate!");

        // Remove MethodOne and call again
        multiDel -= MethodOne;
        multiDel("After removing MethodOne");
    }
}
