class Program
{
  static void Main(string[] args)
  {
    // Address address1 = new Address("123 Main", "Anytown", "Kansas", "66610", "US");
    // Address address2 = new Address("246 Main", "Toronto", "Quebec", "12345", "Canada");

    //Customer customer1 = new Customer("Virgil Cane", address1);
    //Customer customer2 = new Customer("Joe Eh", address2);
    //new Customer("Joe Eh", new Address("246 Main", "Toronto", "Quebec", "12345", "Canada"))

    // Each order consists of the usShipping, foreignShipping, and customer info which includes name and address
    Order order1 = new Order(5, 35, new Customer("Virgil Cane", new Address("123 Main", "Anytown", "Kansas", "66610", "US")));
    // Product product1 = new Product("Plush Cat", "Cat1234", 5, 5);
    // Product product2 = new Product("Plush Dog", "Dog123", 6, 6);

    order1.GetProductsList().Add(new Product("Plush Cat", "Cat1234", 5, 5));
    order1.GetProductsList().Add(new Product("Plush Dog", "Dog123", 6, 6));

    Order order2 = new Order(5, 35, new Customer("Joe Eh", new Address("246 Main", "Toronto", "Quebec", "12345", "Canada")));
    // Product product3 = new Product("Red Power Ranger", "PR123", 10, 2);
    // Product product4 = new Product("Pink Power Ranger", "PR456", 10, 3);

    order2.GetProductsList().Add(new Product("Red Power Ranger", "PR123", 10, 2));
    order2.GetProductsList().Add(new Product("Pink Power Ranger", "PR456", 10, 3));

    Console.WriteLine("Order for customer 1:");
    Console.WriteLine($"\nCustomer 1 shipping label: ");
    Console.WriteLine(order1.RenderShippingLabel());//address1, customer1

    Console.WriteLine("\nHere is packing label for order 1:");
    order1.GeneratePackingLabel(order1.GetProductsList());

    Console.WriteLine($"\nThe total cost for order 1 is ${order1.CalculateTotalCost(order1.GetProductsList())}");

    Console.WriteLine("\nOrder for customer 2:");

    Console.WriteLine("\nCustomer 2 shipping label:");
    Console.WriteLine(order2.RenderShippingLabel()); //address2, customer2

    Console.WriteLine("\nHere is packing label for order 2:");
    order2.GeneratePackingLabel(order2.GetProductsList());

    Console.WriteLine($"\nThe total cost for order 2 is ${order2.CalculateTotalCost(order2.GetProductsList())}");
  }
}