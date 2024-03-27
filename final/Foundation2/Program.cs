// Foundation2 Source Code
// Dennis Skoy
// Mar 2024

class Program
{
    static void Main(string[] args)
    {

        // Create new customers
        Customer customer1 = new Customer("John Deer", new Address("101 Main St", "Fancyville", "Alberta", "Canada"));
        Customer customer2 = new Customer("Jane Smithy", new Address("555 Elk Cir", "Babylon", "CA", "USA"));
        Customer customer3 = new Customer("Jimmy Johns", new Address("202 Oak Ln", "Elsewhere", "FL", "USA"));


        // Create lists of products
        List<Product> products1 = new List<Product>();// list of products for order1
        products1.Add(new Product("Widget", 10000001, 9.99, 2));
        products1.Add(new Product("Gear", 10000002, 19.99, 1));
        products1.Add(new Product("Soda", 10000003, 4.99, 5));


        List<Product> products2 = new List<Product>();// list of products for order2
        products2.Add(new Product("Nothing", 10000000, 0.99, 1));
        products2.Add(new Product("Gear", 10000002, 19.99, 1));
        products2.Add(new Product("Vegan Chips", 10000001, 19.99, 2));


        List<Product> products3 = new List<Product>();// list of products for order3
        products3.Add(new Product("Race Car", 10000101, 29.99, 2));
        products3.Add(new Product("Whisk", 10000059, 14.99, 1));
        products3.Add(new Product("Soda", 10000003, 4.99, 5));


        // Create orders
        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);
        Order order3 = new Order(customer3, products3);


        // Prints the order summaries
        order1.ReturnOrderSummary();
        order2.ReturnOrderSummary();
        order3.ReturnOrderSummary();
    }
}