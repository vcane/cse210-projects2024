/*
Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
*/


using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Please enter your grade percentage. ");
    string percentage = Console.ReadLine();
    int gradePercentage = int.Parse(percentage);
    string finalGrade;
    // int secondNum;
    // char sign;

    if (gradePercentage >= 90)
    {
      finalGrade = "A";
    }
    else if (gradePercentage >= 80)
    {
      finalGrade = "B";
    }
    else if (gradePercentage >= 70)
    {
      finalGrade = "C";
    }
    else if (gradePercentage >= 60)
    {
      finalGrade = "D";
    }
    else
    {
      finalGrade = "F";
    }
    //secondNum = int.Parse(percentage[1].ToString());
    //Console.WriteLine($"Last digit: {secondNum}");
    // if (secondNum >= 7)
    // {
    //   sign = '+';
    // }
    // if (secondNum < 3)
    // {
    //   sign = '-';
    // }
    //Console.WriteLine($"Sign: {sign}");

    if (finalGrade == "C" || finalGrade == "B" || finalGrade == "A")
    {
      if (finalGrade == "A")
      {
        Console.WriteLine("Your final grade is an A. You passed the class!");
      }
      else
      {
        Console.WriteLine($"Your final grade is a {finalGrade}. You passed the class.");
      }
    }
    else
    {
      Console.WriteLine($"Your final grade is a {finalGrade}. Unfortunately, you did not pass the class.");
    }
  }
}