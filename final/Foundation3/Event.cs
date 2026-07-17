class Event
{
    // attributes
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    // methods
    public string Standard() // for the standard description
    {
        return $"'{_eventTitle}'\n{_description}\n{_date} at {_time}\n{_address.ReturnAddress()}";
    }
    public Event(string eventTitle, string description, string date, string time, Address address) // event constructor
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
}