using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int largest = array[0];
        int smallest = array[0];

        for (int i = 1; i < n; i++)
        {
            if (array[i] > largest)
            {
                largest = array[i];
            }
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }


        Console.WriteLine($"The largest element is: {largest}");
        Console.WriteLine($"The smallest element is: {smallest}");
    }
}