using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[][] marks = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number of subjects for student {i + 1}: ");
            int subjects = int.Parse(Console.ReadLine());

            marks[i] = new int[subjects];

            Console.WriteLine($"Enter marks for {subjects} subjects:");
            for (int j = 0; j < subjects; j++)
            {
                Console.Write($"Subject {j + 1}: ");
                marks[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Display total marks per student
        for (int i = 0; i < n; i++)
        {
            int total = 0;
            foreach (int mark in marks[i])
                total += mark;

            Console.WriteLine($"Total marks for Student {i + 1} = {total}");
        }
    }
}
