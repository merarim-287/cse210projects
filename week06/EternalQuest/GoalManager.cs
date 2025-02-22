public class GoalManager
{
    public List<GoalManager> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<GoalManager>();
        _score = 0;
    }

    public void Start()
    {
        DisplayPlayerInfo();
        ListGoalNames();
        ListGoalDetails();
        CreateGoal();
        RecordEvent();
        SaveGoals();
        LoadGoals();
    }

    public void ListGoalNames()
    {

    }

    public void DisplayListGoalNames()

    public void ListGoalDetails()
    {
        Console.Write("Goal details:");
        string goalDetails = Console.ReadLine();
    }

    public void DisplayGoalDetails()
    {
        
    }

    public void CreateGoal()
    {
        
    }

    public void DisplayCreateGoal()
    {

    }

    public void RecordEvent()
    {
        
    }

    public void DisplayRecordEvent()
    {
        
    }

    public void SaveGoal()
    {
        
    }

    public void LoadGoal()
    {
        
    }

    public void DisplayPlayerInfo()
    {
        Console.Write("Name:");
        string playerName = Console.ReadLine();
        Console.Write("Gender: ");
        string gender = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLIne({playerName} {gender} {age});
    }

}