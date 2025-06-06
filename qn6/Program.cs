using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nOriginal Array:");
        for (int i = 0; i <n; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        // Sorting the array using Bubble Sort
        for (int i = 0; i < n- 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }


        Console.WriteLine("\n\nSorted Array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}