class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square();

        square.Display();

        Rectangle rectangle = new Rectangle();

        rectangle.Display();

        Circle circle = new Circle();

        circle.Display();
    }
}