public class Cycling : Activity
{
    private double _distance;
    public Cycling(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
        _activity = "Cycling";
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _activityLength * 60;
    }
    public override double GetPace()
    {
        return _activityLength / _distance;
    }
} 