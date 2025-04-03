using System.IO.Compression;

public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _count = count;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DisplayPrompt();
        CollectResponses();

        DisplayEndingMessage();
        ShowSpinner(3);
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nThink about the following:");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("You have some time to list as many as you can...");
        ShowSpinner(5);
    }
    private void CollectResponses()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing your responses. Press Enter after each one. When you're done, just press Enter on an empty line.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
                break;
            responses.Add(response);
        }

        _count = responses.Count;
        Console.WriteLine($"\nYou listed {_count} items. Well done!");
    }

}