using System;
//plantuml URL

// //www.plantuml.com/plantuml/png/bLF1Qjmm4BthAwOtcsn_m9IIiY4b49gbsvoBrfucehBaIgE5KFBlbIsDLtPyQ4xslD6yUVD6klOa7OLUYm_qZ3t2MPsSD2HQBRs71zUX4ty5V8IV_baDWp9Fz_A4kW5FBWPJPf3jxyr4yCTST8lOW38qmR-iG_LaDdC-dCYIr7lhwO9kG8EpNMZ9Dt2lF7qwfF2p472LP5Vn95mKx62C5wqPv9ufcdlL4zTUwZPeIVY3yQgigREYAxXHVj3ovL2OKIKl86lz9dlSmHAxkwdPieA4zIMMVV1aUtJGvfyTVEawXzw3JD-P0yIhoBlBZkJj5H8MAs8PtGfLBHxGFHfLMFudI4EANX8IvNAF_vcpI-wMp0bXrcJtLwJ3bbJEhCIM2u9ZtacLbp9RmGPcBzZ6DsPaDnksTmALUJmsSB9MJmAPYsSkoTxkPQouYmGL9swN5x2gwyHTBFzT7NPJDOmY8zFPgcuUcu_o-oM7I1bRZDr6znU09qduuABTPsLQN1wsmP2RpsyzQ9uepiGQU9Q5YFcEZ0BcODLyndFZFF2gPReyQtCBRx-ZwT2ncikRUnNNCHDw_Gy0

class Program
{
  static void Main(string[] args)
  {
    Address address1 = new Address("123 Main", "Anytown", "Kansas", "66610", "US");
    Address address2 = new Address("246 Main", "Toronto", "Quebec", "12345", "Canada");

    Customer customer1 = new Customer("Virgil Cane", address1);
    Customer customer2 = new Customer("Joe Eh", address2);

    Order order1 = new Order(5, 35, customer1);
    Product product1 = new Product("Plush Cat", "Cat1234", 5, 5);
    Product product2 = new Product("Plush Dog", "Dog123", 6, 6);

    order1.GetProductsList().Add(product1);
    order1.GetProductsList().Add(product2);

    Order order2 = new Order(5, 35, customer2);
    Product product3 = new Product("Red Power Ranger", "PR123", 10, 2);
    Product product4 = new Product("Pink Power Ranger", "PR456", 10, 3);

    order2.GetProductsList().Add(product3);
    order2.GetProductsList().Add(product4);

    Console.WriteLine("Order for customer 1:");
    Console.WriteLine($"\nCustomer 1 shipping label: ");
    Console.WriteLine(order1.RenderShippingLabel(address1, customer1));

    Console.WriteLine("\nHere is packing label for order 1:");
    order1.GeneratePackingLabel(order1.GetProductsList());

    Console.WriteLine($"\nThe total cost for order 1 is ${order1.CalculateTotalCost(customer1, order1.GetProductsList())}");

    Console.WriteLine("\nOrder for customer 2:");

    Console.WriteLine("\nCustomer 2 shipping label:");
    Console.WriteLine(order2.RenderShippingLabel(address2, customer2));

    Console.WriteLine("\nHere is packing label for order 2:");
    order2.GeneratePackingLabel(order2.GetProductsList());

    Console.WriteLine($"\nThe total cost for order 2 is ${order2.CalculateTotalCost(customer2, order2.GetProductsList())}");
  }
}