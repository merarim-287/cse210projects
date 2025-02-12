public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }

public class Product 
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
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
        public string Name { get; set; }
        public string Address { get; set; }
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

}


