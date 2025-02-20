public class Shape
{
    private string color {get; set; }

    public shape(string color)
    {
        Color = color;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Color: {Color}");
    }
}