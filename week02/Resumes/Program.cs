class Program
{
    public static void Main(string[] args)
    {
        Job job1 = new Job();
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}

public class Job
{
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void GetJobDetails()
    {
        Console.Write("What was your job title? ");
        JobTitle = Console.ReadLine();

        Console.Write("Enter the year you started working there: ");
        StartYear = int.Parse(Console.ReadLine());

        Console.Write("Enter the year you stopped working there: ");
        EndYear = int.Parse(Console.ReadLine());
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"You worked as a {JobTitle} from {StartYear} to {EndYear}");
    }
}