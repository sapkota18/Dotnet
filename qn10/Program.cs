using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Find Reverse of the Number");
            Console.WriteLine("2. Factorial of the Number");
            Console.WriteLine("3. Volume of a Cube");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    int reverse = 0;
                    while (num > 0)
                    {
                        reverse = reverse * 10 + num % 10;
                        num /= 10;
                    }
                    Console.WriteLine("Reverse of the number: " + reverse);
                    break;

                case 2:
                    Console.Write("Enter a number: ");
                    int n = int.Parse(Console.ReadLine());
                    long factorial = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Factorial of the number: " + factorial);
                    break;

                case 3:
                    Console.Write("Enter the side length of the cube: ");
                    double side = double.Parse(Console.ReadLine());
                    double volume = Math.Pow(side, 3);
                    Console.WriteLine("Volume of the cube: " + volume);
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}