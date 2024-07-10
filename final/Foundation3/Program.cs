using System;

// plantuml URL
// //www.plantuml.com/plantuml/dpng/lPF1JiCm38RlUOeWBflONg3YCAGnBWYamNto6ej5j6cLk4CJyEuiMLAdL9pGTcj-_RP_VqqMZi1ILrVYYdPOezphhGL3udwFXkJjrtmk7x6apc8khR74bdHZSl6v8zKqzW5eXrQRDo7A2foJmI8-XRoM6_JVhvegBAIZuFAoGbTQ7JeETQ2XaNJD0ZSyj4CLbBBeNAy9UNEACJa9iY-RoQXa4LW3OeCVtH_6zN7aDCnQer5eNmYC0gkMIA0hDvaMoPnvTesb9Szca_XE0ECFy0ZdSkDQX7UqJy0aWbv22wMcGo6r8PyYrPrzv_wSHPlv539bcif2Ri7XX7iCXuUfSHnx66hFQzLLLUIvQcpQS0oDhsZ4XlMnvcvyBzXuEKvvbd-Z-OiDxpMcCtgh4T871k5OZIKuoZcDIYw7wrUgin4RRPY3I-JYRqkFaImYHMtu73KT1e8Z86J5XuXrYMJUZBVtZVf3Q99l4Ds3g0iqggkh7m00

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Foundation3 World!");
    Address addressEvent = new Address("123 Main", "Anytown", "KS", "66610");
    Event event1 = new Event("Virgil's Event", "An event put on by Virgil.", "1/2/24", "1:00 PM", "Event", addressEvent);
    Console.WriteLine($"Event standard details:");
    Console.WriteLine(event1.RenderStandardDetails());
  }
}