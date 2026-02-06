using System.Drawing;

// Part of how this program exceeds requirements is having the additional large goal.
public class LargeGoal : Goal
{
    private bool _isComplete;
    private int _finalPoints;
    
    public LargeGoal(string name, string description, int points, bool isComplete, int finalPoints) : base(name, description, points)
    {
        _isComplete = isComplete;
        _finalPoints = finalPoints;
    }

    public override int RecordEvent()
    {
        Console.WriteLine("What would you like to record?");
        Console.WriteLine("  1. Working on the goal");
        Console.WriteLine("  2. Completing the goal");
        Console.Write("Select a choice from the menu: ");

        int points = 0;
        int input = int.Parse(Console.ReadLine());
        if(input == 1)
        {
            points = _points;
        }
        else if(input == 2)
        {
            points = _finalPoints;
            _isComplete = true;
        }
    
        return points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"LargeGoal~|~{_name}~|~{_description}~|~{_points}~|~{_isComplete}~|~{_finalPoints}");
        }
    }
}