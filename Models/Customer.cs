namespace DevPrinciples.Models;

public class Customer
{
    public Address Address { get; set; }

    public Customer(Address address)
    {
        Address = address;
    }

    // Method that follows the Law of Demeter
    public string GetStreetName()
    {
        return Address?.Street?.Name;
    }
}