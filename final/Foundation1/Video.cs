class Video
{
    // attributes
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _commentList;
    public Video(string title, string author, int seconds, List<Comment> commentList)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _commentList = commentList;
    }

    // behaviors
    public void Display()
    {
        Console.WriteLine($"{_title} \n Created by: {_author} \n Runtime: {_seconds} seconds");
        foreach (Comment commentSet in _commentList)
        {
            commentSet.Display();
        }
    }

}