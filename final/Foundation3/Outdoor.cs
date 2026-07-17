class Outdoor : Event
{
    // attributes
    private string _weather;
    
    // methods
    public string FullDetails() // unique full details
    {
        return $"'{_eventTitle}'\n{_description}\n{_date} at {_time}\n{_address.ReturnAddress()}\nWeather will be {_weather}.";
    }
    public string Short() // unique short description
    {
        return $"Outdoor Gathering\n'{_eventTitle}'\n{_date}";
    }
    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weather) 
    : base (eventTitle, description, date, time, address)
    {
        _weather = weather;
    }
}