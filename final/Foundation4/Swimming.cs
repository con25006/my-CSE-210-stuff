class Swimming : Activity
{
    // attributes
    private int _laps;

    // methods
    public Swimming(double distance, double speed, double pace, int laps)
    : base (distance, speed, pace)
    {
        _laps = laps;
        
    }
}