using System;

class Program
{
    static void Main(string[] args)
    {
      
        Address address1 = new Address("123 Main St", "Austin", "TX", "USA");
      
        Customer customer1 = new Customer("Daniel", address1);

        Order order1 = new Order(customer1);

        Product p1 = new Product("Mouse", 101, 15, 2);
        Product p2 = new Product("Keyboard", 202, 45, 1);
        Product p3 = new Product("Monitor", 303, 150, 1);
        Product p4 = new Product("Monitor", 303, 150, 1);
        Product p5 = new Product("USB Cable", 404, 10, 3); 

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        
        Console.WriteLine("_____________ORDER 1_______________\n");
        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"TOTAL COST: ${order1.GetTotalCost()}\n");

        Order order2 = new Order(customer1); 
        
        order2.AddProduct(p4); 
        order2.AddProduct(p5); 
      
        Console.WriteLine("_____________ORDER 2_______________\n"); 
        Console.WriteLine(order2.GetPackingLabel()); 
        Console.WriteLine(order2.GetShippingLabel()); 
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");

    }

 }
