class Customer
{
    private string _customerName;
    private Address _address; 


    public Customer (string customerName, Address address)
    {
        _customerName = customerName; 
        _address = address;

    }

    public string GetCustomerName()
    {
        return $"Customer: {_customerName}"; 
    }

    public bool LivesInUSA()
    {
    
        return _address.GetCountry() == "USA";
    }

    public Address GetAddress()
    {
        return _address;
    }

















}