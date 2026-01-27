class Order
{
    private Customer _customer; 
    private List<Product> _products = new List<Product>();

    public Order (Customer customer)
    {
        _customer = customer; 
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in _products)
        {
            label += $"{p.GetProductName()} (ID: {p.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public int GetTotalCost()
    {
        int total = 0;

        foreach (Product p in _products)
        {
            total += p.CalculateTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

}