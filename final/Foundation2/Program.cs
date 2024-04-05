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

        // Create products
        Product gear = new Product("Gear", 10000002, 19.99, 1);
        Product nothing = new Product("Nothing", 10000000, 0.99, 1);
        Product widget = new Product("Widget", 10000001, 9.99, 2);
        Product soda = new Product("Soda", 10000003, 4.99, 5);
        Product veganChips = new Product("Vegan Chips", 10000001, 19.99, 2);
        Product raceCar = new Product("Race Car", 10000101, 29.99, 2);
        Product whisk = new Product("Whisk", 10000059, 14.99, 1);

        // Create product lists for orders
        List<Product> products1 = [widget, gear, soda];// order1 products
        List<Product> products2 = [nothing, gear, veganChips];// order2 products
        List<Product> products3 = [raceCar, whisk, soda];// order3 products

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