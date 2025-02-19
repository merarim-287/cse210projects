public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("Please enter the Product Id and quantity:")
        string input = Console.ReadLine();
        int productId = int.Parse(input);
    
    }
}
public class Product 
{ 
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
    public int Quantity {get; set;}

    public Product(int id, string name, decimal price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public decimal TotalPrice(int quantity)
    {
        return Price * Quantity;
    }

}
public class Order
    {
        public List<Product> Items { get; set; }
        public decimal Total { get; set; }
    }
    public class Cart
    {
        public List<Product> Items { get; set; }
        public decimal Total { get; set; }
    }
    public class Customer
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        string input = Console.ReadLine();
        
        public string Name { get; set; }
    }

    public class shipping
    {
        public decimal Price { get; set; }
        shipping _Price { get; set; }
    }

    public class Payment
    {
        public decimal Amount { get; set; }
        
        return Product + " " + Name + " " + Price + " " + shipping;
    }

    {
        public class Order(List<ProductId)
        {
            public List<ProductId> Items { get; set; }
            public decimal Total { get; set; }
        }
    }

public string GetPackingLabel()
{
    string label ="";

    foreach (ProductId product in Order.Items)
    {
        label += $"Product: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}\n";
    }

    return GetPackingLabel;
}



