class Lectures : Event
{
    // attributes
    private string _speaker;
    private int _capacity;

    // methods
    public string FullDetails() // unique full details
    {
        return $"'{_eventTitle}'\n{_description}\n{_date} at {_time}\n{_address.ReturnAddress()}";
    }
    public string Short() // unique short description
    {
        return $"Lecture\n'{_eventTitle}'\n{_date}";
    }
    public Lectures(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) 
    : base (eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}