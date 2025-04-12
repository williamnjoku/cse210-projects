public class CheckListGoals : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoals(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }
    public int GetBasePoints()
    {
        return _points;
    }

    public int CalculatePointsEarned()
    {
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
    public override string GetProgress()
    {
        return $"{_amountCompleted}/{_target}";
    }


}