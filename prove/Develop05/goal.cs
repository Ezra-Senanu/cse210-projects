using System;
using System.Collections.Generic;
using System.IO;

// Base class for all goals
public abstract class Goal
{
    public string Name { get; private set; }
    public bool IsCompleted { get; protected set; }
    public int Points { get; protected set; }

    // Constructor
    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    // Method to mark goal as completed
    public virtual void MarkCompleted()
    {
        IsCompleted = true;
    }

    // Abstract method to record progress
    public abstract void RecordProgress();

    // Method to get string representation of the goal for saving
    public abstract string GetStringRepresentation();
}

// Class for simple goals
public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string name, int points) : base(name, points) { }

    // Method to record progress
    public override void RecordProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Completed goal: {Name}. You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal {Name} is already completed.");
        }
    }

    // Method to get string representation of the goal for saving
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name}:{Points}:{IsCompleted}";
    }
}

// Class for eternal goals
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, int points) : base(name, points) { }

    // Method to record progress
    public override void RecordProgress()
    {
        Console.WriteLine($"Recorded progress for eternal goal: {Name}. You earned {Points} points.");
    }

    // Method to get string representation of the goal for saving
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name}:{Points}:{IsCompleted}";
    }
}

// Class for checklist goals
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    // Constructor
    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    // Method to record progress
    public override void RecordProgress()
    {
        currentCount++;
        Console.WriteLine($"Recorded progress for checklist goal: {Name}. You earned {Points} points.");

        if (currentCount >= targetCount)
        {
            MarkCompleted();
            Console.WriteLine($"Congratulations! You completed the checklist goal: {Name}. Bonus points earned: {Points * 5}");
        }
    }

    // Method to get string representation of the goal for saving
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name}:{Points}:{IsCompleted}:{targetCount}:{currentCount}";
    }
}

// Class to manage goals
public class GoalManager
{
    private List<Goal> goals;

    // Constructor
    public GoalManager()
    {
        goals = new List<Goal>();
    }

    // Method to add a new goal
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    // Method to display all goals
    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            string status = goal.IsCompleted ? "[X]" : "[ ]";
            if (goal is ChecklistGoal)
            {
                Console.WriteLine($"{status} {goal.Name} (Completed {((ChecklistGoal)goal).currentCount}/{((ChecklistGoal)goal).targetCount} times)");
            }
            else
            {
                Console.WriteLine(status + " " + goal.Name);
            }
        }
    }

    // Method to save goals to a file
    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // Method to load goals from a file
    public void LoadGoals(string fileName)
    {
        goals.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);
                bool isCompleted = bool.Parse(parts[3]);
                if (type == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(name, points) { IsCompleted = isCompleted });
                }
                else if (type == "EternalGoal")
                {
                    goals.Add(new EternalGoal(name, points) { IsCompleted = isCompleted });
                }
                else if (type == "ChecklistGoal")
                {
                    int targetCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);
                    goals.Add(new ChecklistGoal(name, points, targetCount) { IsCompleted = isCompleted, currentCount = currentCount });
                }
            }
        }
    }
}
