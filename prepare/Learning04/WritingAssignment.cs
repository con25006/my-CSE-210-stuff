class WritingAssignment : Assignment
{
    // attributes
    private string _title;

    // behaviors
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string writingInformation = $"{_title} by {_studentName}";
        return writingInformation;
    }
}