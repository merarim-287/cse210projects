public class Square: Shape
{
    private double _side;
    public Square(string color, double _side)
    {
        _side = side;
    }
     
    public override double GetArea()
    {
        return _side * _side;
    }

    public void Display()
    {
        Console.Write({GetArea()});
    }
}