/*
Class: Resume

Attributes (state):
* _name: string
* _jobs: List<Job>

Methods (behaviors):
* DisplayResume(): void

Class: Job

Attributes (state):
* _company: string
* _jobTitle: string
* _startYear: int
* _endYear: int

Methods (behaviors):
* DisplayJob(): void

*/

using System;
public class Job
{
  public string _company = String.Empty;
  public string _jobTitle = String.Empty;
  public int _startYear = 0;
  public int _endYear = 0;

  public Job()
  {
  }

  public void DisplayJobDetails()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
  }
}