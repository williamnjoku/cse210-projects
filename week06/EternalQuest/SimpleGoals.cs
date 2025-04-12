public class SimpleGoals : Goal
{
    private bool _isComplete = false;
    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine("Congratulations! You have completed this goal.");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_name},{_description},{_points}";
    }
    public override string GetProgress()
    {
        return IsComplete() ? "1/1" : "0/1";
    }


}