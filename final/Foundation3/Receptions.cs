class Receptions : Event
{
    // attributes
    private string _email;

    // methods
    public string FullDetails() // unique full details
    {
        return $"'{_eventTitle}'\n{_description}\n{_date} at {_time}\n{_address.ReturnAddress()}\nRSVP at: {_email}";
    }
    public string Short() // unique short description
    {
        return $"Reception\n'{_eventTitle}'\n{_date}";
    }
    public Receptions(string eventTitle, string description, string date, string time, Address address, string email) 
    : base (eventTitle, description, date, time, address)
    {
        _email = email;
    }
}