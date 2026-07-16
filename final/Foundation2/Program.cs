using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("This is the Encapsulation with Online Ordering program.");

        // Customer 1
        Console.WriteLine("---------------------------------------------------------------------");
        Address address1 = new Address("123 Sample Street", "New Sample City", "Wyoming 2", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product c1product1 = new Product("Box of one dozen starving, crazed weasels", "1012", 2, 2);
        Product c1product2 = new Product("LEGO UCS Millenium Falcon", "2022", 800, 1);
        
        List<Product> c1products = new List<Product>();
        c1products.Add(c1product1);
        c1products.Add(c1product2);
        Order order1 = new Order(c1products, customer1);
        
        Console.WriteLine($"{order1.GetPackingLabel()}");
        Console.WriteLine($"Subtotal: ${order1.Subtotal()}");
        Console.WriteLine($"Shipping Cost: ${order1.InUSA()}\n");
        Console.WriteLine($"Grand Total: ${order1.GrandTotal()}\n");
        Console.WriteLine($"{order1.GetShippingLabel()}");
        Console.WriteLine("---------------------------------------------------------------------");
        
        Console.WriteLine("\n\n\n");

        // Customer 2
        Console.WriteLine("---------------------------------------------------------------------");
        Address address2 = new Address("321 Evil Sample Street", "Not New Sample City", "Not Wyoming", "Not USA");
        Customer customer2 = new Customer("Evil John Smith", address2);
        Product c2product1 = new Product("Box of 6 frozen apple fritters", "1001", 8, 4);
        Product c2product2 = new Product("LEGO Death Star", "2025", 1000, 1);
        
        List<Product> c2products = new List<Product>();
        c2products.Add(c2product1);
        c2products.Add(c2product2);
        Order order2 = new Order(c2products, customer2);
        
        Console.WriteLine($"{order2.GetPackingLabel()}");
        Console.WriteLine($"Subtotal: ${order2.Subtotal()}");
        Console.WriteLine($"Shipping Cost: ${order2.InUSA()}\n");
        Console.WriteLine($"Grand Total: ${order2.GrandTotal()}\n");
        Console.WriteLine($"{order2.GetShippingLabel()}");
        Console.WriteLine("---------------------------------------------------------------------");
    }
}