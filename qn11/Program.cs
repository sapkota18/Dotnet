using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i / Factorial(i);
        }

        Console.WriteLine($"The sum of the series is: {sum}");
    }

    static double Factorial(int num)
    {
        double fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
}