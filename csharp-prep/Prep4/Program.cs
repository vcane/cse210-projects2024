class Program
{
  static void Main(string[] args)
  {
    List<int> numbers = new List<int>();
    List<int> positiveNums = new List<int>();
    bool loopAgain = true;
    int sum = 0;

    Console.WriteLine("Please enter an integer (whole number) Enter a zero to stop.");
    while (loopAgain == true)
    {
      Console.Write("Enter number: ");
      int userNum = int.Parse(Console.ReadLine());

      if (userNum != 0)
      {
        numbers.Add(userNum);
      }
      else
      {
        loopAgain = false;
      }
    }

    Console.WriteLine();

    for (int i = 0; i < numbers.Count; i++) // <-- could use a foreach loop also
    {
      sum += numbers[i];
    }

    numbers.Sort();

    foreach (int num in numbers)
    {
      if (num > 0)
      {
        positiveNums.Add(num);
      }
    }

    Console.WriteLine($"The sum is: {sum}.");
    Console.WriteLine($"The average is: {sum / (float)numbers.Count}");
    Console.WriteLine($"The largest number is: {numbers.Max()}");
    Console.WriteLine($"The smallest positive number is: {positiveNums.Min()}");
    Console.WriteLine("The sorted list is:");
    foreach (int num in numbers)
    {
      Console.WriteLine(num);
    }
  }
}