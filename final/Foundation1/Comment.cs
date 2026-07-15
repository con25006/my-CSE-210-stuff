class Comment
{
    // attributes
    public string _commenter;
    public string _commentText;
    
    // behaviors 
    public void Display()
    {
        Console.WriteLine($"{_commenter} \n >{_commentText}");
    }
}