class Customer
{
    public string Name { get; set; }
    public List<name> Names { get; set; } = new List<name>();

    _name = name;
    _lastName = lastName;

    public void AddName(string name, string lastName)
    {
        Names.Add(new Name(name, lastName));
        return Names;
    }
}