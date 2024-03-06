using System;

public class Journal
{
    public List<string> questions = new List<string>()
    {
        "What was the best part of your day?",
        "If ypu could have done something today, what would it be?",
        "Which things am I thankful for today?",
        "What is one thing I do not want to forget about this day?",
    };

    public void JournalQuestions()
    {
        foreach(string question in questions)
        {
            string oneQuestion = Console.ReadLine();
            Console.WriteLine($"{oneQuestion}");
        }
    }

    public void JournalDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();    
        Console.WriteLine($"{dateText}");   
    }
}