using System;

class Program
{
  static void Main(string[] args)
  {
    // Assignment assignment1 = new Assignment("Virgil Cane", "Computer Programming");
    // Console.WriteLine(assignment1.GetSummary());

    // Roberto Rodriguez - Fractions
    // Section 7.3 Problems 8-19

    // MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
    // Console.WriteLine(mathAssignment1.GetSummary());
    // Console.WriteLine(mathAssignment1.GetHomeworkList());

    // Mary Waters -European History
    // The Causes of World War II by Mary Waters
    WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
    Console.WriteLine(writingAssignment1.GetSummary());
    Console.WriteLine(writingAssignment1.GetWritingInformation());
  }
}