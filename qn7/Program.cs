using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] A = new int[rows, cols];
        int[,] B = new int[rows, cols];
        int[,] C = new int[rows, cols];

        Console.WriteLine("Enter elements of Matrix A:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine());
            }

        Console.WriteLine("Enter elements of Matrix B:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"B[{i},{j}] = ");
                B[i, j] = int.Parse(Console.ReadLine());
            }

        // Perform matrix addition
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                C[i, j] = A[i, j] + B[i, j];

        // Display result
        Console.WriteLine("Result of Matrix Addition (A + B):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(C[i, j] + "\t");

            Console.WriteLine();
        }
    }
}
