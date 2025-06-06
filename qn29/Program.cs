using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30 };

        try
        {
            Console.WriteLine("Value at index 3: " + numbers[3]); 
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of bounds.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program continues...");
    }
}
