using System;

public class VotingAgeException : Exception
{
    public VotingAgeException() 
        : base("Age must be 18 or older to vote.")
    {
    }
}

class Program
{
    static void ValidateVotingAge(int age)
    {
        if (age < 18)
            throw new VotingAgeException();
        Console.WriteLine("You are eligible to vote.");
    }

    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            try
            {
                ValidateVotingAge(age);
            }
            catch (VotingAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
