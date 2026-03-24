// This class represents a full order made by a customer. It contains a list of products and a customer.
// It is responsible for adding products, calculating the total cost of the order, and generating labels.
// The total cost includes all product costs plus a shipping fee depending on whether the customer lives in the USA.
// It also builds packing and shipping labels by using information from the Product and Customer classes.d
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        // shipping
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

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product p in _products)
        {
            label += p.GetPackingLabel() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}