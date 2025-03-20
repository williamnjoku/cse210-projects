using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");

        }
        Console.WriteLine("\n");
    }
    public void HideRandomWords(int count = 2) 
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count); 
            _words[index].Hide();
        }
    }

    
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.GetDisplayText().All(c => c == '_'));
    }
    

}