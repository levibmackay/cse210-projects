// This class represents a customer placing an order. It stores the customer's name and their address.
// It has a method to check if the customer lives in the USA by calling the Address class.
// It also creates the shipping label by combining the customer's name with their full address.

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}