using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("103 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("106 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("William", address1);
        Customer customer2 = new Customer("Victor", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(new Product("Laptop", 101, 999.99f, 1));
        order1.AddProduct(new Product("Mouse", 102, 49.99f, 2));

        order2.AddProduct(new Product("Monitor", 103, 199.99f, 1));
        order2.AddProduct(new Product("Keyboard", 104, 89.99f, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}