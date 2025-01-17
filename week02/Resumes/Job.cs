public class Program
{
    public static void Main(string[] args)
    {
        Job job1 = new Job();
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}

public class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }
    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }
    public int StartYear
    {
        get { return _startYear; }
        set { _startYear = value; }
    }

    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    public Job()
    {
        Console.Write("What is the name of the company you worked at?");
        _company = Console.ReadLine();

        Console.Write("What was your jobtitle?");
        _jobTitle = Console.ReadLine();

        Console.Write("Enter the year you started working there:");
        _startYear = int.Parse(Console.ReadLine());

        Console.Write("Enter the year you stopped working there:");
        _endYear = int.Parse(Console.ReadLine());
    }
}


