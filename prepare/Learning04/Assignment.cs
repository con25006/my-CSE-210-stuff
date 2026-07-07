class Assignment
{
    // attributes
    protected string _studentName;
    private string _topic;

    // behaviors
    public Assignment(string studentName, string topic) // assignment constructor
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}