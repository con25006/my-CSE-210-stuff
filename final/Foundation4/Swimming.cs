class Swimming : Activity
{
    // unique attributes
    private int _laps;

    // methods
    public Swimming(string date, double time, int laps)
    : base (date, time)
    {
        _laps = laps;
    }
    public override string GetSummary()
    {
        _distance = ((_laps * 50) / 1000);
        _speed = ((_distance / _time) * 60);
        _pace = (60 / _speed);
        return $"{_date} Swimming ({_time} min): Distance {_distance:F2} km, Speed: {_speed:F2} kph, Pace: {_pace:F2} min per km";
    }
}