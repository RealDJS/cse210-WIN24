// Foundation2 source code
// Dennis Skoy
// Mar 2024

// Address Class

class Address
{
    private string streetAddress;// customer street address
    private string city;// customer city
    private string stateOrProvince;// customer state or province
    private string country;// customer country

    // Constructor
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }


    //Getters
    public string GetStreetAddress() { return streetAddress; }
    public string GetCity() { return city; }
    public string GetStateOrProvince() { return stateOrProvince; }
    public string GetCountry() { return country; }


    //Setters
    public void SetStreetAddress(string streetAddress) { this.streetAddress = streetAddress; }
    public void SetCity(string city) { this.city = city; }
    public void SetStateOrProvince(string stateOrProvince) { this.stateOrProvince = stateOrProvince; }
    public void SetCountry(string country) { this.country = country; }


    // Methods
    /** ToString: Returns a string representation of the address */
    public override string ToString()
    { return streetAddress + "\n" + city + ", " + stateOrProvince + "\n" + country; }


    /** IsUSA: Returns true if the address is in the USA */
    public bool IsUSA() { return country == "USA"; }
}