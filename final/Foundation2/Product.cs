// This class represents a single product in an order. It stores the name, product id, price per unit, and quantity.
// It also has methods to calculate the total cost of that product and return a simple packing label with the name and id.
// This keeps all product related logic in one place so the Order class does not have to deal with those details.

class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} ({_productId})";
    }
}