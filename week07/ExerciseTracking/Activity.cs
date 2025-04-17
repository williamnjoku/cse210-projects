public abstract class Activity
{
    protected string _activity;
    protected DateTime _date;
    protected int _activityLength;
    public Activity(DateTime date, int length)
    {
        _date = date;
        _activityLength = length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual void DisplaySummary()
    {
        Console.WriteLine($"{_date:dd MMM yyyy} {_activity} ({_activityLength})- Distance {GetDistance()} km, Speed {GetSpeed()} kmph, Pace: {GetPace()} min per km. ");
    }

}