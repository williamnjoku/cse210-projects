using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(DateTime.Today, 30, 4.8);
        Swimming swimming = new Swimming(DateTime.Today, 30, 5);
        Cycling cycling = new Cycling(DateTime.Today, 30, 3.0);
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }

    }
}