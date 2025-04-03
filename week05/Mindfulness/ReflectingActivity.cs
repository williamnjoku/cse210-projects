public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a difficult challenge.",
        "Recall a moment when you helped someone in need.",
        "Reflect on a time when you learned something important.",
        "Remember a situation where you showed great patience."
    };
    List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel during this experience?",
        "What did you learn from this situation?",
        "How has this experience shaped who you are today?"
    };

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
        ShowSpinner(3);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nReflect on the following prompt:");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("Take a few moments to think about it...");
        ShowSpinner(5);
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("\nNow, consider these questions:");
        for (int i = 0; i < 3; i++) 
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"- {question}");
            ShowSpinner(5);
        }
    }
}