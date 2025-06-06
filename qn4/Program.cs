using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("The sum of the array is: " + sum);
    }
}