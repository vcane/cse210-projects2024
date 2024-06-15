public class ListingActivity : Activity
{
  private string _nameListing;
  private List<string> _listingPrompts = new List<string>()
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };
  private int _numberOfAnswers = 0;
  private string _listingActivityDescription;

  public ListingActivity()
  {
    _nameListing = " Listing Activity.";
    _listingActivityDescription = " reflect on the good things in your life by having you list as many things as you can in a certain area.";
  }

  public void RunListingActivity()
  {
    Console.WriteLine(GetStartingMessage() + _nameListing);
    Console.WriteLine(GetDescription() + _listingActivityDescription);
    SetDuration();

    Console.WriteLine("Get ready....");
    SpinnerPause();
    Console.Clear();

    Console.WriteLine("List as many responses you can to the question:");
    Console.WriteLine($"---{GenerateRandomListingPrompt()}---");
    Console.WriteLine("Hit enter when you are ready to start answering the question.");
    Console.ReadLine();

    Console.Write("You may begin in... ");
    CountdownPause();
    Console.WriteLine();

    DateTime startTime = DateTime.Now; // TODO figure out how to put the startTime and endTime in a method in Activity or a separate class
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      Console.ReadLine();
      _numberOfAnswers++;
    }
    Console.WriteLine($"You listed {_numberOfAnswers} items!");
    Console.WriteLine(GetCongratulate());
    SpinnerPause();

    Console.WriteLine("\n" + GetEndMessage() + _nameListing);
    SpinnerPause();
  }

  private string GenerateRandomListingPrompt()
  {
    Random random = new Random();
    int index = random.Next(0, _listingPrompts.Count);
    return _listingPrompts[index];
  }
}
