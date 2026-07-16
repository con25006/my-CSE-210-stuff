class Address
{
    // attributes
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // methods
    public bool InUSA()
    {
        string country = _country;
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    
    }
    public string ReturnAddress()
    {
        string address = $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
        return address;
    }
    public Address()
    {
        _streetAddress = "321 Sample Street";
        _city = "Sample City";
        _stateOrProvince = "Wyoming";
        _country = "USA";
    }
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
}