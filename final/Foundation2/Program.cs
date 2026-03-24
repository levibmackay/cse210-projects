// This is the main program where everything is tested. It creates sample addresses, customers, and orders.
// Each order is given multiple products to show how the system handles real scenarios.
// It then prints out the packing label, shipping label, and total cost for each order to verify that everything works together correctly.
class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Levi Mackay", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Basketball", "B001", 20.0, 2));
        order1.AddProduct(new Product("Shoes", "S002", 50.0, 1));

        // Order 2 (International)
        Address address2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("John Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Jersey", "J003", 30.0, 3));
        order2.AddProduct(new Product("Hat", "H004", 15.0, 2));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}