using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample usage
        GoalManager goalManager = new GoalManager();
        goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read scriptures daily", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10));

        // Record progress
        goalManager.DisplayGoals();
        goalManager.SaveGoals("goals.txt");
        goalManager.LoadGoals("goals.txt");
        goalManager.DisplayGoals();
    }
}