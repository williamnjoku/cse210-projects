public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        DisplayStartingMessage();

        int cycles = _duration / 6; 

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in...");
            Thread.Sleep(3000);

            Console.Write("\nBreathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}