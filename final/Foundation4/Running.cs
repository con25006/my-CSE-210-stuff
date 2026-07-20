class Running : Activity
{
    // methods
    public Running(string date, double time, double distance)
    : base (date, time)
    {
        _distance = distance;
    }
    public override string GetSummary()
    {
        _speed = ((_distance / _time) * 60);
        _pace = (_time / _distance);
        return $"{_date} Running ({_time} min): Distance {_distance:F2} km, Speed: {_speed:F2} kph, Pace: {_pace:F2} min per km";
    }
}