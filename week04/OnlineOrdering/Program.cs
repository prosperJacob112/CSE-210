
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create the first customer and order.
        Address address1 = new Address(
            "123 Main Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Jordan Lee", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Notebook", "N101", 3.50m, 2));
        order1.AddProduct(new Product("Pen Set", "P205", 5.00m, 1));

        // Create the second customer and order.
        Address address2 = new Address(
            "45 King Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Avery Chen", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Backpack", "B310", 28.00m, 1));
        order2.AddProduct(new Product("Water Bottle", "W415", 12.00m, 2));

        // Display the first order's total and labels.
        Console.WriteLine($"Order 1 Total: {order1.GetTotalCost():C2}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        // Display the second order's total and labels.
        Console.WriteLine($"Order 2 Total: {order2.GetTotalCost():C2}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}