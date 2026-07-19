class Activity
{
    // common attributes
    private double _distance; // in km
    private double _speed; // in km/h
    private double _pace; // in min/km

    // common methods
    public string GetSummary()
    {
        return "";
    }
    public Activity(double distance, double speed, double pace)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
}