public class VisualizationActivity : Activity
{
    private List<string> _visualizationPrompts = new List<string>
    {
        "Imagine a peaceful beach with the sound of waves crashing.",
        "Picture yourself walking through a serene forest filled with tall trees and birds singing.",
        "Visualize yourself sitting by a calm lake at sunrise, surrounded by nature.",
        "Picture yourself lying on a soft grassy hill under a clear blue sky.",
        "Imagine you're in your favorite place, feeling completely at peace."
    };

    public VisualizationActivity(string name, string description, int duration) : base(name, description, duration)
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

        DisplayVisualizationPrompt();
        GuideVisualization();

        DisplayEndingMessage();
        ShowSpinner(3);
    }

    public string GetRandomVisualizationPrompt()
    {
        Random random = new Random();
        int index = random.Next(_visualizationPrompts.Count);
        return _visualizationPrompts[index];
    }

    public void DisplayVisualizationPrompt()
    {
        string prompt = GetRandomVisualizationPrompt();
        Console.WriteLine("Visualization : " + prompt);
    }

    public void GuideVisualization()
    {
        Console.WriteLine("Now, close your eyes (if you feel comfortable) and take deep breaths.");
        Console.WriteLine("Visualize the scene described in the prompt. Imagine all the details.");
        Console.WriteLine("Focus on the sights, sounds, and feelings associated with your visualization.");
        Console.WriteLine("Spend a few minutes in this calming space, letting yourself relax.");
        Thread.Sleep(_duration * 1000); 
        Console.WriteLine("Great job! I hope you feel more relaxed.");
    }
}