public class WritingAssignment : Assignment
{
    private string _title;
    private string _author;

    public WritingAssignment(string name, string topic, string title, string author) : base(name, topic)
    {
        _title = title;
        _author = author;
    }
    public override string GetAssignmentDetails()
    {
        return $"{_title} by {_author}.";
    }
}