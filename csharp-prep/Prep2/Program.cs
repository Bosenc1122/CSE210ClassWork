using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Input = Console.ReadLine();
        int grade = int.Parse(Input);

        string letter = "";

        if (grade >= 90)
        {
            letter = "Your grade is an A";
        }
        else if (grade >= 80)
        {
            letter = "Your grade is a B";
        }
        else if (grade >= 70)
        {
            letter = "Your grade is a C";
        }
        else if (grade >= 60)
        {
            letter = "Your grade is a D";
        }
        else
        {
            letter = "Your grade is an F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}