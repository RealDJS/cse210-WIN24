// Foundation2 source code
// Dennis Skoy
// Mar 2024

// Product Class

class Product
{
    private string name;// product name
    private int productID;// product ID
    private double price;// product price
    private int quantity;// product quantity

    // Constructor
    public Product(string name, int productID, double price, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.price = price;
        this.quantity = quantity;
    }


    //Getters
    public string GetName() { return name; }
    public int GetProductID() { return productID; }
    public double GetPrice() { return price; }
    public int GetQuantity() { return quantity; }


    //Setters
    public void SetName(string name) { this.name = name; }
    public void SetProductID(int productID) { this.productID = productID; }
    public void SetPrice(double price) { this.price = price; }
    public void SetQuantity(int quantity) { this.quantity = quantity; }


    // Methods
    /** CalcProductCost: Returns the total cost of the product */
    public double CalcProductCost() { return price * quantity; }
}