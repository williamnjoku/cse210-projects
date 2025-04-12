public class EternalGoals : Goal
{
    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"You gained {_points}  points for completing this goal!");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }
    public override string GetStringRepresentation()
    {
    return $"EternalGoal,{_name},{_description},{_points}";
    }
    public override string GetProgress()
    {
        return "Ongoing";
    }

}