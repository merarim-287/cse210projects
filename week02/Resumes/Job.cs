public class Job
{
    public string _jobTitle{get; set;}
    public string _company {get; set;}
    public int _startYear {get; set;}
    public int _endYear {get; set;}

    public Job()
    {
        Console.Write("What is the name of the company you worked at?");
        Company = Console.ReadLine(); 
 
        Console.Write("What was your _jobtitle?");
        JobTitle = Console.ReadLine();

        Console.Write("Enter the year you started working there:");  
        StartYear = int.Parse(Console.ReadLine());

        Console.Write("Enter the year you stopped working there:");
        EndYear = int.Parse(Console.ReadLine());
    }
}
