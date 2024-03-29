// Foundation 3 source code
// Dennis Skoy
// Mar 2024

// Address class

class Address
{
	private string street;// street address
	private string city;// city
	private string stateOrProvince;// state or province
	private string country;// country

	// Constructor
	public Address()
	{
		this.street = "Street";
		this.city = "City";
		this.stateOrProvince = "State/Province";
		this.country = "Country";
	}
	public Address(string street, string city, string stateOrProvince, string country)
	{
		this.street = street;
		this.city = city;
		this.stateOrProvince = stateOrProvince;
		this.country = country;
	}

	// Getters
	public string GetStreet() { return street; }
	public string GetCity() { return city; }
	public string GetStateOrProvince() { return stateOrProvince; }
	public string GetCountry() { return country; }

	// Setters
	public void SetStreet(string street) { this.street = street; }
	public void SetCity(string city) { this.city = city; }
	public void SetStateOrProvince(string stateOrProvince) { this.stateOrProvince = stateOrProvince; }
	public void SetCountry(string country) { this.country = country; }

	// Methods
	/** ToString: returns a string representation of the address */
	public override string ToString()
	{ return street + "\n" + city + ", " + stateOrProvince + " " + country; }
}