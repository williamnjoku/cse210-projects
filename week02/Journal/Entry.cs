using System.IO; 
public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;
    
    public Entry(PromptGenerator promptGen)
    {
        _prompt = promptGen.GetRandomPrompt();  
        Console.WriteLine(_prompt);
        
        _response = Console.ReadLine();  
        _date = DateTime.Now.ToString("yyyy-MM-dd");  
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine($"Date: {_date}");
            writer.WriteLine($"Prompt: {_prompt}");
            writer.WriteLine($"Response: {_response}");
            writer.WriteLine(new string('-', 50)); 
        }
    }

}