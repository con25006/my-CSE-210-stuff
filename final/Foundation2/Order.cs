class Order
{
    // attributes
    private List<Product> _productList;
    private Customer _customer;
    private string _packingLabel;
    private string _shippingLabel;

    // behaviors
    public int Subtotal()
    {
        int subtotal = 0;
        foreach(Product product in _productList)
        {
            subtotal += product.TotalCost();
        }
        return subtotal;
    }
    public int InUSA()
    {
        int shippingCost = 5;
        if (_customer.InUSA() == false)
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public string GetShippingLabel()
    {
        _shippingLabel = $"{_customer.ShippingLabel()}";
        return _shippingLabel;
    }
    public string GetPackingLabel()
    {
        _packingLabel = "";
        foreach (Product product in _productList)
        {
            _packingLabel += $"{product.PackingLabel()}\n";
        }
        return _packingLabel;
    }
    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }
    public int GrandTotal()
    {
        int grandTotal = Subtotal() + InUSA();

        return grandTotal;
    }

}