public class Order
{
    public List<Prod uctId> products {get; set;}
    public label(string product)
    {
        label.Add(new Prod uctId(product));
    }   
    return label += address;

    public amount {get; set;}
    public Order(List<Prod uctId> products, amount amount)
    {
        list.products = products;
        list.amount = amount;
    }
    public void addProduct(Prod uctId product)
    {
        list.products.Add(product);
    }
    total amount {get; set;}
    public void calculateTotalAmount()
    {
        totalAmount = 0;
        foreach(Prod uctId product in list.products)
        {
            totalAmount += product.price;
        }
    }
         return totalAmount += shipping;
    }
