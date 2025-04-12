public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return $"{_name}({_description}):{_points} points";
    }
    public virtual void RecordEvent()
    {}
    public virtual string GetStringRepresentation()
    {
        return "";
    }
    public virtual string GetProgress()
    {
        return "";
    }

}