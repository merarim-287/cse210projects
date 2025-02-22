public class Goal: GoalManager
{
    public string GoalName {get; set;}
    public string GoalDescription {get; set;}
    public double GalPoints {get; set;}



    public void RecordEvent()
    {
        
    }


    public bool IsComplete()
    {
        
    }   

    public string GetDetailsString()
    {
        return {GoalName. GoalDescription, GoalPoints};
        
    }

    public string GetStringRepresentation()
    {
        return {GoalName};
    }
}

