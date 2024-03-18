using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Cyril Kofi", "Discrete Math");
        Console.WriteLine(a1.GetSummary());

    
        MathAssignment a2 = new MathAssignment("Albert Quansah", "Permutations", "6.5", "9-18");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Florence Nightingale", "Passwords", "How many passwords can be generated?");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}