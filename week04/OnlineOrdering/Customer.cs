public class Customer
{
    public string Name { get; set; }
    Name = name;
}

public class Address {
    public string Street {get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}

public Address(string street, string city, string state, string country) {
    Street = street;
    City = city;
    State = state;
    Country = country;
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