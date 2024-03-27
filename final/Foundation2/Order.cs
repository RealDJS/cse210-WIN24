// Foundation2 Source Code
// Dennis Skoy
// Mar 2024

// Order Class

class Order
{
    private Customer customer;// customer information
    private List<Product> products;// list of products in the order

    // Constructor
    public Order(Customer customer, List<Product> products)
    { this.customer = customer; this.products = products; }


    //Getters
    public Customer GetCustomer() { return customer; }

    public List<Product> GetProducts() { return products; }


    //Setters
    public void SetCustomer(Customer customer) { this.customer = customer; }

    public void SetProducts(List<Product> products) { this.products = products; }


    // Methods
    /**ReturnOrderSummary: Lists the customer's name and address, the product name, ID, and quantity of each product in the order, and the total cost of the order */
    public void ReturnOrderSummary()
    {
        Console.WriteLine(new string("-"[0], Console.WindowWidth - 1)); // prints a border 
        Console.WriteLine();
        Console.WriteLine(ReturnShippingLabel());// print the customer's name and address
        Console.WriteLine();
        Console.WriteLine("Contents:");
        Console.WriteLine(ReturnPackingLabel());// print the packing label
        Console.WriteLine();
        Console.WriteLine("Order Total: $" + Math.Round(ReturnOrderCost(), 2));// print the order total
        Console.WriteLine();
    }


    /** ReturnPackingLabel: lists the name and productId of each product in the order */
    public string ReturnPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)// for each product in the order
        {
            string name = product.GetName();// get the product name
            int id = product.GetProductID();// get the product ID
            int columnWidth = 12;// width of the column
            packingLabel += name.PadRight(columnWidth) + id + "\n";// add the product name and ID to the packing label
        }
        return packingLabel;
    }


    /**ReturnShippingLabel: Lists the customer's name and address*/
    public string ReturnShippingLabel() { return customer.ToString(); }


    /**ReturnOrderCost: Returns the total cost of the order*/
    public double ReturnOrderCost() { return CalcShippingCost() + CalcOrderTotal(); }// return the shipping cost plus the order total


    /** CalcOrderTotal: Returns the total cost of the order */
    private double CalcOrderTotal()
    {
        double total = 0;
        foreach (Product product in products)// for each product in the order
        { total += product.CalcProductCost(); }// add the product cost to the total
        return total;
    }


    /** CalcShippingCost: Returns the shipping cost of the order */
    private double CalcShippingCost()
    {
        if (customer.IsUSA()) { return 5; }// if the customer is in the USA
        else { return 35; }// if the customer is not in the USA
    }
}