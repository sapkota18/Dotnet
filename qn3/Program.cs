using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 1)
        {
            bool isPrime = true;
            int largestFactor = 1;

            for (int i = 2; i <= number / 2; i++)
            {
            if (number % i == 0)
            {
                isPrime = false;
                largestFactor = i;
            }
            }

            if (isPrime)
            Console.WriteLine($"{number} is a prime number.");
            else
            Console.WriteLine($"Largest factor of {number} is {largestFactor}.");
        }
        else
        {
            Console.WriteLine("Please enter a number greater than 1.");
        }
    }
}