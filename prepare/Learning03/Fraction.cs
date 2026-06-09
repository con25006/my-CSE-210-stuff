using System.Dynamic;
using System.Globalization;

class Fraction



{
    // attributes
    private int _top;
    private int _bottom;

    // Fraction function options
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
            _top = top;
            _bottom = bottom;
    }

    // Getters and setters for tops and bottoms
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // the other two
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {

        double decimalValue = (double)_top / _bottom;
        return decimalValue;
    }
}