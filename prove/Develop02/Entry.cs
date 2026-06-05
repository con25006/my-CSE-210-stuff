class Entry
{
    // attributes
    public string _date;
    public string _prompt;
    public string _response;
    
    // behaviors
    public void Display()
    {
        Console.WriteLine($"{_date} -- {_prompt} \n {_response}");
    }

}