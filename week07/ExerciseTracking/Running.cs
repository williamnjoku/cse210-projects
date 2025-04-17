public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
        _activity = "Running";
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