using System;

class Sum
{
    static void Main()
    {
        int num, sum = 0;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}
