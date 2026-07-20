class Cycling : Activity
{
    // methods
    public Cycling(string date, double time, double speed)
    : base (date, time)
    {
        _speed = speed;
    }
    public override string GetSummary()
    {
        _distance = ((_speed * _time) / 60);
        _pace = (60 / _speed);
        return $"{_date} Cycling ({_time} min): Distance {_distance:F2} km, Speed: {_speed:F2} kph, Pace: {_pace:F2} min per km";
    }
}