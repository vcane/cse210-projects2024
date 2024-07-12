using System;

// plantuml URL
// //www.plantuml.com/plantuml/dpng/lPF1JiCm38RlUOeWBflONg3YCAGnBWYamNto6ej5j6cLk4CJyEuiMLAdL9pGTcj-_RP_VqqMZi1ILrVYYdPOezphhGL3udwFXkJjrtmk7x6apc8khR74bdHZSl6v8zKqzW5eXrQRDo7A2foJmI8-XRoM6_JVhvegBAIZuFAoGbTQ7JeETQ2XaNJD0ZSyj4CLbBBeNAy9UNEACJa9iY-RoQXa4LW3OeCVtH_6zN7aDCnQer5eNmYC0gkMIA0hDvaMoPnvTesb9Szca_XE0ECFy0ZdSkDQX7UqJy0aWbv22wMcGo6r8PyYrPrzv_wSHPlv539bcif2Ri7XX7iCXuUfSHnx66hFQzLLLUIvQcpQS0oDhsZ4XlMnvcvyBzXuEKvvbd-Z-OiDxpMcCtgh4T871k5OZIKuoZcDIYw7wrUgin4RRPY3I-JYRqkFaImYHMtu73KT1e8Z86J5XuXrYMJUZBVtZVf3Q99l4Ds3g0iqggkh7m00

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Foundation3 World!");
    Address addressEvent = new Address("123 Main", "Anytown", "KS", "66610");

    Lecture lecture = new Lecture("Gravity really pulls you down", "Lecture on gravity", "7/11/22", "10 AM", "Lecture", addressEvent.RenderAddress(), "Virgil Cane", 1000);

    Lecture lecture1 = new Lecture("Buoyancy is really bouncy.", "Bouncy lecture", "7/11/24", "10 am", "Lecture", addressEvent.RenderAddress(), "Virgil Cane", 100000);

    Console.WriteLine($"Virgil's Lecture Short Description: ");
    Console.WriteLine(lecture.RenderShortDescription());

    Console.WriteLine("\nVirgil's Lecture Standard Details:");
    Console.WriteLine(lecture.RenderStandardDetails());

    Console.WriteLine("\nVirgil's Lecture Full Details:");
    Console.WriteLine(lecture.RenderFullDetailsForLecture());

    Console.WriteLine("\nLecture Short Description: ");
    Console.WriteLine(lecture1.RenderShortDescription());

    Console.WriteLine("\nLecture Standard Details:");
    Console.WriteLine(lecture1.RenderStandardDetails());

    Console.WriteLine("\nLecture Full Details:");
    Console.WriteLine(lecture1.RenderFullDetailsForLecture());
  }
}