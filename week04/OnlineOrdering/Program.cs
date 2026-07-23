using System;

class Program
{
    static void Main(string[] args)
    {
        // first order, customer in the USA
        Address address1 = new Address("123 Maple Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("James Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM100", 24.99, 1));
        order1.AddProduct(new Product("Keyboard", "KB250", 49.99, 1));
        order1.AddProduct(new Product("USB Cable", "UC010", 7.50, 2));

        // second order, customer outside the USA
        Address address2 = new Address("Rua das Flores 88", "Sao Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Carla Souza", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook Stand", "NS300", 32.00, 1));
        order2.AddProduct(new Product("Webcam", "WC720", 58.90, 1));

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
