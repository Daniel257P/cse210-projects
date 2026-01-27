class Product
{
    private string _productName;
    private int _productId;
    private int _price; 
    private int _quantity; 


    public Product (string productName, int productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId; 
        _price = price; 
        _quantity = quantity; 
    }

    public int CalculateTotalCost()
    {
        return  _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

     public void DisplayProductInfo ()
    {
        Console.WriteLine($"Product:{_productName} - {_productId}\n Price: {_price}, Units: {_quantity}"); 
    }


}





   

