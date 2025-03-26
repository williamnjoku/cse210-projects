public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberComments()
    {
        return _comments.Count;
        
    }
    public void GetListComments()
    {
        foreach (Comment c in _comments)
        {
            c.GetComments();
        }
    }
     public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberComments()}");
        Console.WriteLine("Comments:");
        GetListComments();
        Console.WriteLine("--------------------------------------");
    }
    
}