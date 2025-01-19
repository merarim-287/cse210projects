using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    public static void Main(string[] args)
    {
        Job job1 = new Job();
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
class Job
{
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void ()
    {
        Console.Write("What was your job title? ");
        jobTitle = Console.ReadLine();

        Console.Write("Enter the year you started working there: ");
        startYear = int.Parse(Console.ReadLine());

    Console.Write("Enter the year you stopped working there: ");
        endYear = int.Parse(Console.ReadLine());
}

public void DisplayJobDetails()
{
    Console.WriteLine($"You worked as a {JobTitle} from {StartYear} to {EndYear}");
}
}