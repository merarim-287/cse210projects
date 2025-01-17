using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}

public class Job
{
    public string _jobTitle;    
        Console.Write("What was your _jobtitle?");
        Job.Title = Console.ReadLine();

    public int _startYear;
        Console.Write("Enter the year you started working there:");  
        Job.StartYear = Console.ReadLine();
    public int _endYear;
        Console.Write("Enter the year you stopped working there:");
        Job.EndYear = Console.ReadLine();
}

DisplayJobDetails
    Console.WriteLine($"You worked at {Company} as a {Job} from {StartYear} to {EndYear}");