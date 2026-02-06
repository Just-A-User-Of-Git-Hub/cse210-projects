using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _completionsNeeded;
    private int _completions;
    private int _bonusPoints;
    
    public ChecklistGoal(string name, string description, int points, int completionsNeeded, int completions, int bonusPoints) : base(name, description, points)
    {
        _completionsNeeded = completionsNeeded;
        _completions =  completions;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _completions += 1;
        int points = _points;
        if(_completions == _completionsNeeded)
        {
            points += _bonusPoints;
        }
        return points;
    }
    public override bool IsComplete()
    {
        if(_completions >= _completionsNeeded)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"ChecklistGoal~|~{_name}~|~{_description}~|~{_points}~|~{_completions}~|~{_completionsNeeded}~|~{_bonusPoints}");
        }
    }
    public override string GetDetails()
    {
        return $"{_name} ({_description}) -- Currently completed: {_completions}/{_completionsNeeded}";
    }
}