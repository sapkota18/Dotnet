using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Display length
        Console.WriteLine("Length: " + input.Length);

        // Display in uppercase and lowercase
        Console.WriteLine("Uppercase: " + input.ToUpper());
        Console.WriteLine("Lowercase: " + input.ToLower());

        // Check if it contains "hello"
        if (input.ToLower().Contains("hello"))
            Console.WriteLine("The string contains 'hello'");
        else
            Console.WriteLine("The string does not contain 'hello'");

        // Find the index of first occurrence of 'a'
        int index = input.IndexOf('a');
        if (index != -1)
            Console.WriteLine("First occurrence of 'a' is at index: " + index);
        else
            Console.WriteLine("The letter 'a' is not found in the string.");
    }
}
