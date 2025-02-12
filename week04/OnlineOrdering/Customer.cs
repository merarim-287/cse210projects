public class Customer
{
    public string Name { get; set; }
    Name = name;

    public Customer(string name) : this(default)
    {
        Name = name;
    }
}

public class Customer {
    public Address Address { get; set; }
    Address = address;

    Adress address = new Adress(street, city, state, country);
    Customer customer = new Customer(name, address);
}

public Customer (string name, Address address) {
    return Customer(name, address);
}