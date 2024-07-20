class Program
{
  static void Main(string[] args)
  {
    List<Order> orderList = new List<Order>()
    {
      new Order(5, 35, new Customer("Virgil Cane", new Address("123 Main", "Anytown", "Kansas", "66610", "US"))),
      new Order(5, 35, new Customer("Joe Eh", new Address("246 Main", "Toronto", "Quebec", "12345", "Canada")))
    };

    // adding products to orders
    orderList[0].AddProduct(new Product("Plush Cat", "Cat1234", 5, 5));
    orderList[0].AddProduct(new Product("Plush Dog", "Dog123", 6, 6));
    orderList[1].AddProduct(new Product("Red Power Ranger", "PR123", 10, 2));
    orderList[1].AddProduct(new Product("Pink Power Ranger", "PR456", 10, 3));

    Console.WriteLine("Order for customer 1:");
    Console.WriteLine($"\nCustomer 1 shipping label: ");
    Console.WriteLine(orderList[0].RenderShippingLabel());

    Console.WriteLine("\nHere is packing label for order 1:");
    orderList[0].GeneratePackingLabel();

    Console.WriteLine($"\nThe total cost for order 1 is ${orderList[0].CalculateTotalCost()}");

    Console.WriteLine("\nOrder for customer 2:");

    Console.WriteLine("\nCustomer 2 shipping label:");
    Console.WriteLine(orderList[1].RenderShippingLabel());

    Console.WriteLine("\nHere is packing label for order 2:");
    orderList[1].GeneratePackingLabel();

    Console.WriteLine($"\nThe total cost for order 2 is ${orderList[1].CalculateTotalCost()}");
  }
}