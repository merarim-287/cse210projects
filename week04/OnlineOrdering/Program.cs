public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! this is the online ordering project.");
    }
}

public class Order
{
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal TotalPrice {get; set;}
    public List<Product> Products {get; set;}

    public Order()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalPrice += product.Price;
    }

public void Label()
{ 
    private Customer customerName;
    private Adress address;
    private Order order;


    Console.WriteLine("Product Name\t\tProduct\t\tProduct Quantity");
    foreach (Product product in Products)
    {
        Console.WriteLine($"{product.Name}\t\t{product.Price}\t\t{product.Quantity}\t\t{customerName.Name}\t\t{adress.Adress}");

    }
}