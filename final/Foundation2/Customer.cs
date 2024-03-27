// Foundation2 source code
// Dennis Skoy
// Mar 2024

// Customer Class

class Customer
{
    private string name;// customer name
    private Address address;// customer address

    // Constructor
    public Customer(string name, Address address)
    { this.name = name; this.address = address; }


    //Getters
    public string GetName() { return name; }
    public Address GetAddress() { return address; }


    //Setters
    public void SetName(string name) { this.name = name; }
    public void SetAddress(Address address) { this.address = address; }


    // Methods
    /** IsUSA: Returns true if the customer is in the USA */
    public bool IsUSA() { return address.IsUSA(); }


    /** ToString: Returns a string representation of the customer */
    public override string ToString() { return name + "\n" + address.ToString(); }
}