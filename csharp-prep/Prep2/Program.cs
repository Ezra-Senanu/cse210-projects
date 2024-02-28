using System;

class Program
{
    static void Main(string[] args)
    {
        //prompt user for their grade percentage 
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade_letter = "";
        //use an if statemnt to determine the grade letter

        if (percent >= 90)
        {
            grade_letter = "A";
        }
        else if (percent >= 80)
        {
            grade_letter = "B";
        }
        else if (percent >= 70)
        {
            grade_letter = "C";
        }
        else if (percent >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }

        Console.WriteLine($"Your grade is: {grade_letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}