namespace DevPrinciples.Models;

public class Order
{
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
    }
}