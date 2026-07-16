class Product
{
    // attributes
    private string _productName;
    private string _productID;
    private int _productPrice;
    private int _productCount;
    
    // behaviors
    public int TotalCost()
    {
        int totalCost = _productCount * _productPrice;
        return totalCost;
    }
    public Product(string productName, string productID, int productPrice, int productCount)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productCount = productCount;
    }

    public string PackingLabel()
    {
        return $"ID-{_productID} -- {_productName} (${_productPrice}) x{_productCount}";
    }

}