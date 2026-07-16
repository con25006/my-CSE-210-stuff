class Customer
{
    // attributes
    private string _name;
    private Address _address;

    // behaviors
    public bool InUSA()
    {
        if (_address.InUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ShippingLabel()
    {
        string shippingLabel = $"{_name}\n{_address.ReturnAddress()}";
        return shippingLabel;
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}