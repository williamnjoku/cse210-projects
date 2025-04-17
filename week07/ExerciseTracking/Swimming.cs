public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        _activity = "Swimming";
    }
    public override double GetDistance()
    {
        return _laps * 50.0 /1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _activityLength * 60;
    }
    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
    
}