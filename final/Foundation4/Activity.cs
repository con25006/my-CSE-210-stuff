class Activity
{
    // common attributes
    protected double _distance; // in km
    protected double _speed; // in km/h
    protected double _pace; // in min/km
    protected string _date;
    protected double _time; // in min
    

    // methods
    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_time} min): Distance {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }
    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }
}